<?php
# Video Store Rental Index
# James Sahler Parsons jam2090280

require_once "sampdb_pdo.php";

$title = "Video Store Rental Website";
html_begin ($title, $title);
?>

<p>Welcome to the Video Store!</p>

<?php
try
{
  $dbh = sampdb_connect ();
}
catch (PDOException $e) { } # empty handler (catch but ignore errors)
?>

<p>
See customers <a href="show_customers.php">here</a>.   <!-- loads the customer table and form -->
</p>

<p>
See videos <a href="show_videos.php">here</a>    <!-- loads the video form -->
</p>

<p>
To see late videos click <a href="show_late2.php">here</a>!  <!-- loads the late video form -->
</p>


<p>
To rent a movie click here <a href="movie_rental.php">here</a>! <!-- loads the movie rental form -->
</p>


<?php
html_end ();
?>
