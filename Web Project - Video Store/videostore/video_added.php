

<?php 

# Video Store Rental video_added.php
# James Sahler Parsons jam2090280

require_once "sampdb_pdo.php";

$dbh = sampdb_connect ();

# placeholders
try { 
$sql = 'INSERT INTO videostore.video SET 
`videoID` = :videoID, 
`title` = :title,
`genre` = :genre,
`director` = :director,
`producer` = :producer,
`year` = :year,
`actor1` = :actor1,
`actor2` = :actor2,
`rented` = :rented';

$stmt2 = $dbh->prepare($sql);

# replaces placeholders with values entered by the user in the POST array
$stmt2->bindValue(':videoID', $_POST['videoID']);
$stmt2->bindValue(':title', $_POST['title']);
$stmt2->bindValue(':genre', $_POST['genre']);
$stmt2->bindValue(':director', $_POST['director']);
$stmt2->bindValue(':producer', $_POST['producer']);
$stmt2->bindValue(':year', $_POST['year']);
$stmt2->bindValue(':actor1', $_POST['actor1']);
$stmt2->bindValue(':actor2', $_POST['actor2']);
$stmt2->bindValue(':rented', $_POST['rented']);

 $stmt2->execute();
 header('location: show_videos.php');
} 
catch (PDOException $e) 
{ 
 echo 'Sorry the video information you entered is  invalid - probably a repeat video ID number';
}


 ?>
 
 <!-- button to go back to the videos page -->
 
<form action="show_videos.php" method="post"> 
  
  <p>
<input type="submit" value="Back to movie list"> 
</form>


