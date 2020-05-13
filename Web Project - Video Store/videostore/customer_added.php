

<?php 

# Video Store Rental customer_added.php
# James Sahler Parsons jam2090280

require_once "sampdb_pdo.php";

$dbh = sampdb_connect ();

# leaves a placeholder for values to be entered
try { 
$sql = 'INSERT INTO videostore.customer SET 
`customerID` = :customerID, 
`FirstName` = :FirstName,
`LastName` = :LastName,
`BirthDate` = :BirthDate,
`Address` = :Address,
`Phone` = :Phone,
`Email` = :Email';

$stmt2 = $dbh->prepare($sql);

# then replaces the placeholders with values from the POST array

$stmt2->bindValue(':customerID', $_POST['customerID']);
$stmt2->bindValue(':FirstName', $_POST['FirstName']);
$stmt2->bindValue(':LastName', $_POST['LastName']);
$stmt2->bindValue(':BirthDate', $_POST['BirthDate']);
$stmt2->bindValue(':Address', $_POST['Address']);
$stmt2->bindValue(':Phone', $_POST['Phone']);
$stmt2->bindValue(':Email', $_POST['Email']);

# and insterts them into the database
 $stmt2->execute();
 header('location: show_customers.php');
} 
catch (PDOException $e) 
{ 
 echo 'Sorry the customer information you entered is  invalid - probably a repeat customer number';
}

 ?>
 
 <!-- button for going back to the customer page -->
 
<form action="show_customers.php" method="post"> 
  
  <p>
<input type="submit" value="Back to customer list"> 
</form>



