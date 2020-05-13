## extractIP
##
## INFV 320
## James Sahler Parsons
## Final Project - Capstone
## February 26th, 2019.
##
## extractIP
## This program reads IP addresses
## from a file named wireShark.txt
## and extracts the source and
## destination IP addresses
## and writes them to IPAddresses.txt
##

def read_and_write():

    ## open the files
    infile = open("wireShark.txt", "r")
    outfile = open("IPAddresses.txt", "w")

    outfile.write("Source \t\tDestination \n") # writes header line

    aline = infile.readline()       # prime the read
  
    while aline:
                
        # runs the checkline function, which takes
        # the line and sees if it is a header line,
        # or blank. if line is blank it skips it,
        # if it is a header line, headsup becomes 1         
        headsup = checkline(aline)
     
        if headsup == 1:                    # if line is header line
            aline2 = infile.readline()      # take the next line and
            items = aline2.split()          # split it into components.
            ip_list = capture_ip(items[2])  # Then sets the source ip address
                                            # to ip_list, and the destination
            ip_list2 = capture_ip(items[3]) # ip address to ip_list2

            write_ip(ip_list, ip_list2, outfile) # writes lists to file

        aline = infile.readline()   # move to the next line
            
    infile.close()      # close the files
    outfile.close()

    print("new file was created, check for IPAddresses.txt") # alerts user
    
## this function receives a line, and tests to see if it is a header line
def checkline(test_line):
    items = test_line.split()   # splits the line into components
    signaler = 0                # and tests those components to
                                # see if they are blank or headers

    if items == []:             # if component is blank, line is blank
        signaler = 0            # so set signaler to 0
    elif items[0] == "No."and items[1] == "Time" and items[2] == "Source" \
       and items[3] == "Destination" and items[4] == "Protocol" \
       and items[5] == "Length" and items[6] == "Info":
        signaler = 1    # if they are headers, signaler becomes 1
  
    return signaler     # returns signaler
 

## this function takes a portion of the current line (the ip address)
## the only reason to do this is the instructions said so.
def capture_ip(portion):
    ip_list = []
    for element in portion:         # take each character in portion
        ip_list.append(element)     # and add it to the ip_list list
    return ip_list


## this funtion takes the 2 lists (source and destination IP addresses)
## and the file to write to, and writes the lists to the file
def write_ip(source_list, destination_list, file):
    for element in source_list:     # iterates through the source list
        file.write(element)         # and writes each element to file
    file.write("\t")
    for element in destination_list:# iterates through the dest. list
        file.write(element)         # and writes each element to file
    file.write("\n")



def main():
    read_and_write()

main()








