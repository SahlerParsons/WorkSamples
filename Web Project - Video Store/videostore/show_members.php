<?php
# show_members Video Store Rental
# James Sahler Parsons jam2090280

require_once "sampdb_pdo.php";

$title = "Video Store Customer List";
html_begin ($title, $title);

$dbh = sampdb_connect ();

# issue statement
$stmt = "SELECT * FROM videostore.customer";
$sth = $dbh->query ($stmt);

print ("<table>\n");          # begin table
# read results of statement, then clean up
#@ _ROW_PRINT_LOOP_
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

 <form action="try2.php" method="post"> 
 
 <p>
 <label for="firstname">First name:</label>
 <input type="text" name="firstname" id="firstname">
 
<p>
<label for="lastname">Last name:</label> 
<input type="text" name="lastname" id="lastname">

<p>
<label for="customerID">Customer ID:</label> 
<input type="integer" name="customerID" id="customerID">

<p>
<input type="submit" value="GO"> 
</form>
