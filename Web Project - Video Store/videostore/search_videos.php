 
 <?php
# search_videos Video Store Rental
# James Sahler Parsons jam2090280

require_once "sampdb_pdo.php";

$dbh = sampdb_connect ();

$video = $_POST['videoID2'];

# issue statement
$stmt = "SELECT * FROM videostore.video WHERE videoID = $video";
$sth = $dbh->query ($stmt);

try { 
print ("<table>\n");          # begin table
# read results of statement, then clean up
#@ _ROW_PRINT_LOOP_

# print the headers
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

} 
catch (PDOException $e) 
{ 
 echo 'Sorry the video information you entered is  invalid - probably a repeat video number';
}
?>

<p>
<p>

<!-- button to go back to the videos form -->
<form action="show_videos.php" method="post"> 
  
  <p>
<input type="submit" value="Back to video list"> 
</form>

<p>
<p>
end of page

<!-- this 'end of page' stuff is included because in my browser a tooltip comes up when
you get near the bottom of the screen and makes it hard to select the final button otherwise -->