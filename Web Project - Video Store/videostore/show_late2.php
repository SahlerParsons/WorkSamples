
<?php
# show_late2.php - video store rental
# James Sahler Parsons jam2090280

require_once "sampdb_pdo.php";

$title = "Video Store Customer List";
html_begin ($title, $title);

$dbh = sampdb_connect ();

# issue statement
$stmt = "SELECT customerid, DATE_FORMAT(daterented,'%m/%d') AS dateRented, DATE_FORMAT(datereturned,'%m/%d') AS dateReturned, dayslate, (dayslate * 2) as amountdue FROM videostore.late_rental WHERE dayslate > 0";
$sth = $dbh->query ($stmt);

print ("<table>\n");          # begin table
# read results of statement, then clean up
#@ _ROW_PRINT_LOOP_

# print headers
print("<tr>");
print("<td>  Customer ID </td>  <td>  Date Rented  </td>  <td> Date Returned </td>  <td> Days Late </td>  <td> Amount Due </td>");
  print ("</tr>\n");
  
# iterate through the table
while ($row = $sth->fetch (PDO::FETCH_NUM))
{
  print ("<tr>\n");           # begin table row
  for ($i = 0; $i < $sth->columnCount (); $i++)
  {
    # escape any special characters and print table cell
    print ("<td>" . htmlspecialchars ($row[$i]) . "</td>\n") . '          ';
  }
  print ("</tr>\n");          # end table row
}
#@ _ROW_PRINT_LOOP_
print ("</table>\n");         # end table


$dbh = NULL;  # close connection

html_end ();
?>

<!-- button to return to index page-->

<form action="index.php" method="post"> 
  
  <p>
<input type="submit" value="Back to Main Page"> 
</form>

<p>
<p>
End of Page

<!-- this 'end of page' stuff is included because in my browser a tooltip comes up when
you get near the bottom of the screen and makes it hard to select the final button otherwise -->
