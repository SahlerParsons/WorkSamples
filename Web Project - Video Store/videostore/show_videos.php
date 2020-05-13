<?php
# show_videos Video Store Rental
# James Sahler Parsons jam2090280

require_once "sampdb_pdo.php";

$title = "Video Store Customer List";
html_begin ($title, $title);

$dbh = sampdb_connect ();

# issue statement
$stmt = "SELECT * FROM videostore.video";
$sth = $dbh->query ($stmt);

print ("<table>\n");          # begin table
# read results of statement, then clean up
#@ _ROW_PRINT_LOOP_

# print headers
print("<tr>");
print("<td>  Video ID </td>  <td>  Title  </td>  <td> Genre </td>  <td> Director </td> <td> Producer </td> <td> Year </td> <td> Actor 1 </td> <td> Actor 2 </td> <td> Rented </td>");
  print ("</tr>\n");
  
# iterate through the table
while ($row = $sth->fetch (PDO::FETCH_NUM))
{
  print ("<tr>\n");           # begin table row
  for ($i = 0; $i < $sth->columnCount (); $i++)
  {
    # escape any special characters and print table cell
    print ("<td>" . htmlspecialchars ($row[$i]) . "</td>\n");
  }
  print ("</tr>\n");          # end table row
}
#@ _ROW_PRINT_LOOP_
print ("</table>\n");         # end table

$dbh = NULL;  # close connection

html_end ();
?>

<p>
<p>

<!-- add video form -->

 <b>Add New Video:</b>

 <form action="video_added.php" method="post"> 
 
 <p>
<label for="videoID">Video ID:</label> 
<input type="integer" name="videoID" id="videoID">
 
 <p>
 <label for="title">Title:</label>
 <input type="text" name="title" id="title">
 
<p>
<label for="genre">Genre:</label> 
<input type="text" name="genre" id="genre">

<p>
<label for="director">Director:</label> 
<input type="text" name="director" id="director">

<p>
<label for="producer">Producer:</label> 
<input type="text" name="producer" id="producer">

<p>
<label for="year">Year:</label> 
<input type="date" name="year" id="year">

<p>
<label for="actor1">Actor 1:</label> 
<input type="text" name="actor1" id="actor1">

<p>
<label for="actor2">Actor 2:</label> 
<input type="text" name="actor2" id="actor2">

<p>
<label for="rented">Rented:</label> 
<input type="boolean" name="rented" id="rented">

<p>
<input type="submit" value="Add Video"> 
</form>

 <form action="search_videos.php" method="post"> 
 
  <p>
<label for="videoID2">Video ID:</label> 
<input type="integer" name="videoID2" id="videoID2">
 
 <p>
<input type="submit" value="Search videos"> 
</form>

<form action="index.php" method="post"> 
  
  <p>
<input type="submit" value="Back to Main Page"> 
</form>

<p>
<p>
End of Page

<!-- this 'end of page' stuff is included because in my browser a tooltip comes up when
you get near the bottom of the screen and makes it hard to select the final button otherwise -->
