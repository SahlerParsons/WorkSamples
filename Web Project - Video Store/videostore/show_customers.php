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

?>
<p>
<p>

<!-- add customer form -->
 <b>Add New Customer:</b>

 <form action="customer_added.php" method="post"> 
 
 <p>
<label for="customerID">Customer ID:</label> 
<input type="integer" name="customerID" id="customerID">
 
 <p>
 <label for="FirstName">First name:</label>
 <input type="text" name="FirstName" id="FirstName">
 
<p>
<label for="LastName">Last name:</label> 
<input type="text" name="LastName" id="LastName">

<p>
<label for="BirthDate">Birthday:</label> 
<input type="date" name="BirthDate" id="BirthDate">

<p>
<label for="Address">Address:</label> 
<input type="text" name="Address" id="Address">

<p>
<label for="Phone">Phone #:</label> 
<input type="integer" name="Phone" id="Phone">

<p>
<label for="Email">Email:</label> 
<input type="text" name="Email" id="Email">

<p>
<input type="submit" value="Add Customer"> 
</form>


 <form action="search_customer.php" method="post"> 
 
  <p>
<label for="customerID2">Customer ID:</label> 
<input type="integer" name="customerID2" id="customerID2">
 
 <p>
<input type="submit" value="Search customer"> 
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







