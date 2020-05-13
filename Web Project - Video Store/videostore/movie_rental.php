
<?php
# movie_rental.php - video store rental
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

# prints the headers
print("<tr>");
print("<td>  Customer ID </td>  <td>  Date Rented  </td>  <td> Date Returned </td>  <td> Days Late </td>  <td> Amount Due </td>");
  print ("</tr>\n");
  
# then iterates through the rows and columns (cells) and prints the values within
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

<!-- The form for renting a movie with all the text boxes, the values are sent to the movie_rented.php -->

<b> Rent a Movie </b>

 <form action="movie_rented.php" method="post"> 
 
  <p>
 <label for="rentalID">Rental ID:</label>
 <input type="integer" name="rentalID" id="rentalID">

 <p>
 <label for="customerID">Customer ID:</label>
 <input type="integer" name="customerID" id="customerID">
 
<p>
<label for="videoID">Video ID:</label> 
<input type="integer" name="videoID" id="videoID">

<p>
<label for="dateRented">Date Rented:</label> 
<input type="date" name="dateRented" id="dateRented">

<p>
<label for="duedate">Due Date:</label> 
<input type="date" name="duedate" id="duedate">

<p>
<label for="dateReturned">Date Returned:</label> 
<input type="date" name="dateReturned" id="dateReturned">

<p>
<label for="daysLate">Days Late:</label> 
<input type="integer" name="daysLate" id="daysLate">

<p>
<label for="feeCharge">Fees Charged:</label> 
<input type="integer" name="feeCharge" id="feeCharge">

<p>
<input type="submit" value="Update Rental Info"> 
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

