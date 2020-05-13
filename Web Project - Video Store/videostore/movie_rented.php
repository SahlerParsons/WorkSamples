

<?php 

# Video Store Rental movie_rented.php
# James Sahler Parsons jam2090280

require_once "sampdb_pdo.php";

$dbh = sampdb_connect ();

# placeholders for values entered by the user
try { 
$sql = 'INSERT INTO videostore.rental SET 
`rentalID` = :rentalID,
`customerID` = :customerID,
`videoID` = :videoID, 
`dateRented` = :dateRented,
`duedate` = :duedate,
`dateReturned` = :dateReturned,
`daysLate` = :daysLate,
`feeCharge` = :feeCharge';

$stmt2 = $dbh->prepare($sql);

# replaces the placeholders with values from the POST array
$stmt2->bindValue(':rentalID', $_POST['rentalID']);
$stmt2->bindValue(':customerID', $_POST['customerID']);
$stmt2->bindValue(':videoID', $_POST['videoID']);
$stmt2->bindValue(':dateRented', $_POST['dateRented']);
$stmt2->bindValue(':duedate', $_POST['duedate']);
$stmt2->bindValue(':dateReturned', $_POST['dateReturned']);
$stmt2->bindValue(':daysLate', $_POST['daysLate']);
$stmt2->bindValue(':feeCharge', $_POST['feeCharge']);

# enters the values into the database
 $stmt2->execute();
 header('location: movie_rental.php');
} 
catch (PDOException $e) 
{ 
 echo 'Sorry the video information you entered is  invalid - probably a repeat video ID, customer ID number, Rent ID number';
}


 ?>
 
 <!-- button for going back to the rental page -->
 
<form action="movie_rental.php" method="post"> 
  
  <p>
<input type="submit" value="Back to movie rental form"> 
</form>