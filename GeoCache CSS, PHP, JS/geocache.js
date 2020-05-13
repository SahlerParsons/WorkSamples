// James Sahler Parsons CSCV337 Final Project April 27th, 2019.  Geocaching

// takes the JSON element sent over from the database and parses it
locationsFromDb = JSON.parse(locationsFromDb);
var markers = [];

// this took me so long to figure out...
function clickTable(clicked_id) {
    markers[clicked_id-1].infowindow.open(map, markers[clicked_id-1]);
}

var map;
function initMap() {
    // starts the map at tucson
    var tucson = {
        lat: 32.253,
        lng: -110.912
    };
    // map options
    var options = {
        zoom: 8,
        center: tucson
    };
    // new map
    map = new google.maps.Map(document.getElementById('mapWindow'), options);
    // if someone clicks search, first make the circle
    if (isSearch) {
        var circle = new google.maps.Circle({
            strokeColor: '#FF0000',
            strokeOpacity: 0,
            strokeWeight: 2,
            fillColor: '#FF0000',
            fillOpacity: 0,
            map: map,
            center: {
                lat: theLat, // these are gotten through php back in geocahce.php (or sent from)
                lng: theLng
            },
            radius: (radius * 1609)
        });
        var bounds = circle.getBounds();
        var locations = [];
        var tableHtml = '';
        for (var i = 0; i < locationsFromDb.length; i++) {
            var location = locationsFromDb[i];
            // get lat and lng
            var markerPosition = {
                lat: parseFloat(location.latitude),
                lng: parseFloat(location.longitude)
            };
            if (bounds.contains(new google.maps.LatLng(parseFloat(location.latitude), parseFloat(location.longitude)))) {
                var markerInfoWindow = new google.maps.InfoWindow({
                    content: ''
                });
                // if the cache is withing the lat / long, make markers
                var marker = new google.maps.Marker({
                    position: markerPosition,
                    map: map,
                    infowindow: markerInfoWindow
                });
                // add the click listeners for the picture infowindows
                marker.addListener('click', function () {
                    this.infowindow.open(map, this);
                });
                var html = "";
                getFlickrImagesByLocation(location.latitude, location.longitude, location.cache_type_id, location.difficulty_rating);
                markers.push(marker);
                tableHtml += '<tr id="marker_'+markers.length+'" onClick="clickTable('+markers.length+');"><td>' + html + location.latitude + '</td><td>' + location.longitude + '</td><td>' + location.difficulty_rating + '</td><td>' + location.cache_type_id + '</td></tr>';                
            }
            document.getElementById('location-table-body').innerHTML = tableHtml;
        }
    }
}



// actually getting the images that go with each marker.  It did not really make sense to use the 
// bounding box dimensions, as that would give one set of pictures for ALL the markers within
// the same bounding box - so all markers would have the same 12 pictures
function getFlickrImagesByLocation(lat, lng, cache_type_id, difficulty_rating, html) {
    html = '';
    var endpoint = 'https://api.flickr.com/services/rest/';
    var ajax = new XMLHttpRequest(); // could not get the ajax stuff to work the way we did it in module 5
    ajax.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            res = this.responseText;
            res = JSON.parse(res);
            for (var i = 0; i < markers.length; i++) {
                var marker = markers[i];
                // had to change the decimal places to match, otherwise would get no results
                if (marker.getPosition().lat().toFixed(6) == parseFloat(lat).toFixed(6) && marker.getPosition().lng().toFixed(6) == parseFloat(lng).toFixed(6)) {
                    var photos = res.photos.photo;
                    html += '<h2> Latitude: ' + lat + ' Longitude: ' + lng + '</h2>';
                    html += '<h2> Cache Type: ' + cache_type_id + ' Difficulty: ' + difficulty_rating + '</h2>';
                    for (var j = 0; j < photos.length; j++) {
                        var photo = photos[j];
                        html += '<img src="https://farm' + photo.farm + '.staticflickr.com/' + photo.server + '/' + photo.id + '_' + photo.secret + '_t.jpg" class="marker-img" >';
                    }
                    marker.infowindow.setContent(html);
                }
            }
        }
    }
    // it is either this or a bbox
    ajax.open("GET", endpoint + '?api_key=306bff23cae2ddc1f606f9fee1d10c2e&method=flickr.photos.search&format=json&perpage=12&nojsoncallback=1&lat=' + lat + '&lon=' + lng);
    ajax.send();
}







window.onload = function () {
    loadList();
    loadListDifficulty();
    loadListCacheType();

}




//*****************************************  Loading the lists  *******************************************//

// populate the lists on the php page
function loadList() {
    var radius = document.getElementById("radius");
    var mileageList = ["5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55", "60", "65", "70", "75", "80", "85", "90", "95", "100", "105", "110", "115", "120", "125", "130", "135", "140", "145", "150", "155", "160", "165", "170", "175", "180", "185", "190", "195", "200"]
    for (var i = 0; i < mileageList.length; i++) {
        var opt = mileageList[i];
        var option = document.createElement("option");
        option.textContent = opt;
        option.value = opt;
        radius.add(option);
    }
    radius.value = "10";
}

function loadListDifficulty() {
    var difficulty = document.getElementById("difficulty");
    var difficultyList = [1, 2, 3, 4, 5, 6, 7, 8, 9];
    var option = document.createElement("option");
    option.textContent = 'All';
    option.value = 0;
    difficulty.add(option);
    for (var i = 1; i < 10; i++) {
        var option = document.createElement("option");
        option.textContent = i;
        option.value = i;
        difficulty.add(option);
    }
}

function loadListCacheType() {
    var cacheType = document.getElementById("cacheType");
    //    var cacheTypeList = ["Traditional", "Mystery / Puzzle", "Multi-Cache"]
    var option = document.createElement("option");
    option.textContent = 'Any';
    option.value = 0;
    cacheType.add(option);
    var option2 = document.createElement("option");
    option2.textContent = "Traditional";
    option2.value = 1;
    cacheType.add(option2);
    var option3 = document.createElement("option");
    option3.textContent = "Mystery / Puzzle";
    option3.value = 2;
    cacheType.add(option3);
    var option4 = document.createElement("option");
    option4.textContent = "Multi-Cache";
    option4.value = 3;
    cacheType.add(option4);
}



