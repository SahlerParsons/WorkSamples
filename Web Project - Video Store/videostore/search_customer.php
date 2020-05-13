 
 <?php
# search_customer Video Store Rental
# James Sahler Parsons jam2090280

require_once "sampdb_pdo.php";

$dbh = sampdb_connect ();

$customer = $_POST['customerID2'];

# issue statement
$stmt = "SELECT * FROM videostore.customer WHERE customerID = $customer";
$sth = $dbh->query ($stmt);

try { 
print ("<table>\n");          # begin table
# read results of statement, then clean up
#@ _ROW_PRINT_LOOP_

# print the headers
print("<tr>");
print("<td>  Customer ID </td>  <td>  First Name  </td>  <td> Last Name </td>  <td> Birthday </td> <td> Address </td> <td> Phone </td> <td> Email </td>");
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
 echo 'Sorry the customer information you entered is  invalid - probably a repeat customer number';
}
?>

<p>
<p>

<!-- button to go back to the customers page -->

<form action="show_customers.php" method="post"> 
  
  <p>
<input type="submit" value="Back to customer list"> 
</form>

<p>
<p>
end of page

<!-- this 'end of page' stuff is included because in my browser a tooltip comes up when
you get near the bottom of the screen and makes it hard to select the final button otherwise -->