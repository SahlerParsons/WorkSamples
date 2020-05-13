'''
James Sahler Parsons
CYBV 473 Violent Python
Final Project
April 25th - May 7th, 2020.
Version 1.0 - Methods not factored out


     Sleeper Cell Finder.  This program uses tweepy and twitter to find sleeper 
cells communicating over twitter.  First it searches by area.  It collects
the usernames of whomever sends tweets from this area.  Then it looks at the location
of those following these tweets to see if any are in the United States and if they 
are it displays them.  So if a few people in a small american city are following tweets 
coming from suspicious territory, it could reveal something troubling, like a sleeper cell.
'''

import twitter       # Library installation    pip install python-twitter
import sys
import tweepy        # 3rd party library       pip install tweepy
import time
import argparse
from prettytable import PrettyTable     # 3rd party library    pip install PrettyTable    


CONSUMER_KEY        = 'joQzH62w6fTqHMvTboKJcSUdw'
CONSUMER_SECRET     = 'UPiP394vcWSQv7eSZ0DgOF2D5jbN4gX92VIDpcwr294WHTVEJj'
ACCESS_TOKEN_KEY    = '1248445614427262979-VjMNRBbiWa6vVy1tOdmmqX81xmuUht'
ACCESS_TOKEN_SECRET = '7GYOldir1Ax0l4PKx1yteYtAmFy2Itxt0NhdBaPNSXfrH'

auth = tweepy.OAuthHandler(CONSUMER_KEY, CONSUMER_SECRET)
auth.set_access_token(ACCESS_TOKEN_KEY, ACCESS_TOKEN_SECRET)

api = tweepy.API(auth, wait_on_rate_limit=True)

# a virable dictionary to hold user names
users = dict()

# a dictionary to hold user names and followers in the USA
american_followers = dict()

#-----------------------------------------------------------------------------------
# Parser section, to get user inputs

''' Create a parser object '''
parser = argparse.ArgumentParser('Sample Argument Parsing')

''' Add possible arguments to the parser object '''
parser.add_argument('-v', '--verbose', action="store_true", help="Verbose prints more information about captured tweets")
parser.add_argument('-c', '--city',    required=True, help="Specifies a chosen city. 1) Tehran, 2) Baghdad, 3) Tripoli 4) North Korea \
          5) Jakarta 6) Moscow 7) Yemen 8) Islamabad") 
parser.add_argument('-t', '--time',  required=True, help="Time (in seconds) to run stream for")


''' Process the arguments '''
args = parser.parse_args()   

verbose = args.verbose
chosen_city = args.city
global_time = args.time


#--------------------------------------------------------------------------------------

class MyStreamListener(tweepy.StreamListener):
    
    # set user-input time to a float, and print out message
    gt = float(global_time)
    print("Capturing tweets for ", gt, " seconds ")
    
    # sets the timeout limit for the stream #
    def __init__(self, time_limit=gt):
        self.start_time = time.time()
        self.limit = time_limit
        super(MyStreamListener, self).__init__()    

## timing gotten from https://stackoverflow.com/questions/33498975/unable-to-stop-streaming-in-tweepy-after-one-minute, ##
## answer #23 by yprez ##

        # grabs information from the twitter stream, printing out values like text, retweet count, and place #
        # depending on level of verbosity chosen #
    def on_status(self, status):
        if (time.time() - self.start_time) < self.limit:       
            print("Text: ", status.text)
            print("User ID: ", status.user.id, " Screen Name: ", status.user.screen_name)
            if verbose == True:
                if status.coordinates:
                    print("Coords: ", status.coordinates)
                if status.geo:
                    print("Geo: ", status.geo)
                if status.place:
                    print("Place: ", status.place)
                if status.retweet_count:
                    print("Retweet Count: ", status.retweet_count)
                if status.lang:
                    print("Language: ", status.lang)
                if status.place.name and status.place.country:
                    print("City, Country: ", status.place.name, ", ", status.place.country)
            print("\n")
          

            # create a dictionary for each individual person tweeting and add values for ID, Place, etc #
            individual_user = dict()
            
            individual_user["ID"] = status.user.id
            individual_user["Screen_Name"] = status.user.screen_name
            individual_user["Place"] = status.place.name
            individual_user["Country"] = status.place.country
            
            # set the key value of each individual as their screen name (or id if you change them)
            key_value = status.user.screen_name
            #key_value = status.user.id
            
            # set each individual dictionary into a dictionary of all user's #
            users[key_value] = individual_user
            
            return True
        else:
            return False           
            
myStreamListener = MyStreamListener()
myStream = tweepy.Stream(auth = api.auth, listener=myStreamListener, wait_on_rate_limit=True, wait_on_rate_limit_notify=True) 

#----------------------------------------------------------------------------------------------
# finding tweets by geographic loaction

# geo boxes gotten from https://boundingbox.klokantech.com/ #

if(chosen_city == '1'):
    print("Searching tweets originating from Tehran\n")
    GEOBOX = [51.270,35.568,51.579,35.828]        
elif(chosen_city == '2'):
    print("Searching tweets originating from Baghdad\n")
    GEOBOX = [44.273,33.225,44.479,33.415]
elif(chosen_city == '3'):
    print("Searching tweets originating from Tripoli\n")
    GEOBOX = ([13.0094,32.7077,13.4645,32.9554])    
elif(chosen_city == '4'):
    print("Searching tweets originating from North Korea / PyongYang area\n")
    GEOBOX = [125.250,38.411,127.737,40.383]  
elif(chosen_city == '5'):
    print("Searching tweets originating from Jakarta\n")
    GEOBOX = [106.748121,-6.280878,106.944962,-6.099295]
elif(chosen_city == '6'):
    print("Searching tweets originating from Moscow\n")
    GEOBOX = [37.335,55.552,37.881,55.922]
elif(chosen_city == '7'):
    print("Searching tweets originating from Yemen\n")
    GEOBOX = [42.87,12.33,52.56,18.75]
elif(chosen_city == '8'):
    print("Searching tweets originating from Islamabad\n")
    GEOBOX = [72.8973,33.5692,73.2113,33.835]
    
myStream.filter(locations=GEOBOX)   
    
#------------------------------------------------------------------------------------------
# section to find the followers of each user that are in the USA
    
print("Finding followers of each user")

## list of abbreviations gotten from https://www.50states.com/abbreviations.htm ##  
usa_list = [' AL', ' AK', ' AZ', ' AR', ' CA', ' CO', ' CT', ' DE', ' FL', ' GA', ' HI', ' ID', ' IL', ' IN', ' IA', ' KS', ' KY', 
            ' LA', ' ME', ' MD', ' MA', ' MI', ' MN', ' MS', ' MO', ' MT', ' NE', ' NV', ' NH', ' NJ', ' NM', ' NY', ' NC', ' ND',
            ' OH', ' OK', ' OR', ' PA', ' RI', ' SC', ' SD', ' TN', ' TX', ' UT', ' VT', ' VA', ' WA', ' WV', ' WI', ' WY', ' DC', 
            'USA', ' MH', ' AE', ' AA', ' AP']    

# iterate through the user's dictionary #
for x,y  in users.items():
    
    # set the user's name to send to the twitter api #
    USER_HANDLE = x

    try:
        # get information on the user #
        user = api.get_user(USER_HANDLE, count=190)

        # for every follower of the user, get their location #
        for follower in user.followers():
            state_country = follower.location[-3:]
            
            ''' if follower's location is in the USA create an individual_follower dictionary 
            with the followers name and locations - then add that entry into the american_followers 
            dictionary by the the user's screen_name (key) '''
            if state_country in usa_list:
                individual_follower = dict()
                individual_follower['Follower_Name'] = follower.screen_name
                individual_follower['Location'] = follower.location
                american_followers[USER_HANDLE] = individual_follower
                
    except:
        print("User not found")
        continue
    
#--------------------------------------------------------------------------------------------
# section to print out the results
    
# if any followers are from the USA, iterate through the list of them and 
# print them out in a pretty table.
if american_followers:
    
    output_table = PrettyTable()
    output_table.field_names = ["Original Tweeter", "Follower Screen Name", "Location"]
    
    for x, y in american_followers.items():
        output_table.add_row([x, y['Follower_Name'], y['Location']])  
    print(output_table)
    
else:
    print("No followers were from the USA in this batch")