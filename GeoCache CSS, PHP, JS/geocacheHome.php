<!-- 
    CSCV337 Final Project James Sahler Parsons, April 27th, 2019. 
-->
<?php
    // sets default values for when the page first loads
    $lng = -110.855554;
    $lat = 32.225952;
    $type = 2;
    $difficulty = 9;
    $radius = 20;
    $search =true;  

if(!empty($_POST['search-button'])){
    $lat = $_POST['lat'];
    $lng = $_POST['lng'];
    $type = $_POST['type'];
    $difficulty = $_POST['difficulty'];
    $radius = $_POST['radius'];
    $search = true;
}

// in case the user leaves blank the lat or lng
if($lng == "") {
    $lng = -110.855554;
}
if($lat == "") {
	$lat = 32.225952;	
}

function search_for_caches($cache_type_id, $difficulty_rating) { 
    $db = new PDO("mysql:host=150.135.53.5;dbname=test;port=3306", "student", "B3@rD0wn!");
//    $db = new PDO("mysql:host=localhost;dbname=geocache;port=3306", "root", "");
    $db->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $query = "SELECT * 
    FROM test_data
    JOIN cache_types ON cache_types.type_id = test_data.cache_type_id";

    if($difficulty_rating != 0){
        $query .=" AND difficulty_rating = $difficulty_rating";
    }
    if($cache_type_id != 0){
        $query .=" AND cache_type_id = $cache_type_id";
    }

    $results = $db->query($query);
    $rows = $results->fetchAll();
	
    return json_encode($rows);
}

?>

<!DOCTYPE html>
<html>
<head>
    <title>Geocaching is fun</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width">
    <link href="geocache.css" type="text/css" rel="stylesheet" />
    
    <script src="http://ajax.googleapis.com/ajax/libs/prototype/1.6.1.0/prototype.js" type="text/javascript"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/scriptaculous/1.8.3/scriptaculous.js" type="text/javascript"></script>
</head>

<body>
    <main>
        <div class="left-col">
            <div class="formWindow" id="formWindow"  >
                <h1> Geocache Locations </h1>
                <h3> Use map to enter a location, or enter by coordinates below: </h3>
                <form class="location" id="location" method="POST">
                    <label>Latitude:</label><input type="text" id="lat" name="lat" class="textarea" value=""><br>
                    <label>Longitude:</label><input type="text" id="lng" name="lng" class="textarea" value=""><br>
                    <label>Radius (miles):</label>
                    <select id="radius" class="textarea" name="radius">
                    </select><br>
                    <label>Cache Type:</label><select id="cacheType" class="textarea" name="type"></select><br>
                    <label>Difficulty:</label><select id="difficulty" class="textarea" name="difficulty"></select><br>
                    <input type="submit" value="Search" name="search-button">
                </form>
                <h2>Nearby Geocaches</h2>
            </div>
            <table id="location-table"> 
                <thead>
                <tr>
                    <th>Latitude</th>
                    <th>Longitude</th>
                    <th>Difficulty</th>
                    <th>Cache Type</th>
                </tr>
                </thead>
                <tbody id="location-table-body">
                </tbody>
            </table>
        </div>
        <div class="right-col">
            <div class="mapWindow" id="mapWindow"></div>
        </div>
        <div id="sandbox"></div>
        <div id="error"></div>
    </main>

	

<script>
    // an easier way to 'pass' the php to the javascript
    var theLat = <?php echo($lat); ?>;
    var theLng = <?php echo($lng); ?>;
    var radius = <?php echo($radius); ?>;
    var locationsFromDb = '<?php echo search_for_caches($type,$difficulty); ?>';
    var isSearch = <?php echo($search); ?>;
</script>
	<script src="geocache.js"></script>
<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyC_VFq7PFUqq9LdwkRGIaRJz70neFxu8C8&callback=initMap" async defer></script>
</body>

</html>






        
    

