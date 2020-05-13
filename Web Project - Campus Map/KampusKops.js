//KampusKops Javascript file

window.onload = function () {
    var map = document.getElementById("mainMap");
    var remedy = document.getElementById("icon");
    var mainMapDiv = document.getElementById("mainMapDiv");
    map.addEventListener("click", getClickPosition);
    map.addEventListener("click", getXofClick);
    map.addEventListener("click", getYofClick);
    map.addEventListener("click", getXYofClick);
    document.getElementById("startButton").addEventListener("click", startGame);
    document.getElementById("endButton").addEventListener("click", endGame);
    cop.addEventListener("click", getClickPosition2);
    detective.addEventListener("click", getClickPosition3);
    squadCar.addEventListener("click", getClickPosition4);
    helicopter.addEventListener("click", getClickPosition5);
    tank.addEventListener("click", getClickPosition6);
}

var map = document.getElementById("mainMap");
var timer = document.getElementById("countdownTimer");
var breaking = document.getElementById("breaking");
var innerBreaking = document.getElementById("innerBreaking");
var currentJobs = document.getElementById("currentJobs");
var highScoreElement = document.getElementById("highScore");
var currentScore = document.getElementById("currentScore");
var currentScoreScore = document.getElementById("currentScoreScore");
var innerCurrentJobs = document.getElementById("innerCurrentJobs");
var innerBreaking = document.getElementById("innerBreaking");

var xpos;
var ypos;
var cancelTimer = false;
var countUp = 0;
var remedyLevel = 0;
var score = 0;
var crimes = [];
var highScore = 0;

var cop = document.getElementById("cop");
var detective = document.getElementById("detective");
var squadCar = document.getElementById("squadCar");
var helicopter = document.getElementById("helicopter");
var tank = document.getElementById("tank");


// ***************  Game Play / Timers *************************************************************//

function startGame() {
    countUp = 0;
    setTimeout(endGame, 120000);
    startTimer();
    cancelTimer = false;
    triggerCrime();
}



timer.innerHTML = 02 + ":" + "00";


function startTimer() {
    var presentTime = timer.innerHTML;
    var timeArray = presentTime.split(/[:]+/);
    var m = timeArray[0];
    var s = checkSecond((timeArray[1] - 1));
    if (s == 59) {
        m = m - 1
    }


    timer.innerHTML =
        m + ":" + s;
    if (cancelTimer == false) {
        if (countUp != 120) {
            setTimeout(startTimer, 1000);
            countUp = countUp + 1;
        }
    } else {
        timer.innerHTML = 02 + ":" + "00";
    }
}

function checkSecond(sec) {
    if (sec < 10 && sec >= 0) {
        sec = "0" + sec
    }; // add zero in front of numbers < 10
    if (sec < 0) {
        sec = "59"
    };
    return sec;
}


function endGame() {
    //    alert("the end");
    cancelTimer = true;
    if (score > highScore) {
        highScore = score;
        highScoreElement.innerHTML = ("High Score" + "\n" + highScore.toFixed(2));
    }
}


//*************************************The Map Portion **************************************//

function getClickPosition(e) {
    var xposition = e.clientX;
    var yposition = e.clientY;
    xpos = xposition;
    ypos = yposition;
}



function getXofClick() {
    return xpos;
}

function getYofClick() {
    return ypos;
}

function getXYofClick() {
    getXofClick;
    getYofClick;
    getGridZoneOfClickEvent();
}

function getXYofClick2() {
    getXofClick;
    getYofClick;
    getGridZoneOfClickEvent();
}

var mainMap = document.getElementById("mainMap");

rect = mainMap.getBoundingClientRect();


var gridZones = [];
gridZones = getGridArea();
setNamesToGridZones();

function getGridArea() { // each gridZone should have four numbers, the two x values to check, the 2 y values
    var mainMap = document.getElementById("mainMap");
    var rect = mainMap.getBoundingClientRect();
    var vertGridSlice = rect.height / 8;
    var horGridSlice = rect.width / 8;
    var gridNum = 0;
    for (var i = 0; i < 8; i++) {
        var xLeft = (rect.left + (i * horGridSlice));
        var xRight = xLeft + horGridSlice;
        for (var x = 0; x < 8; x++) {
            var yTop = (rect.top + (x * vertGridSlice));
            var yBottom = yTop + vertGridSlice;
            gridNum = gridNum + 1;
            gridZones[gridNum] = {
                gridNumber: gridNum,
                gridActive: false,
                gridId: gridNum,
                xL: xLeft,
                xR: xRight,
                yT: yTop,
                yB: yBottom
            };
        }
    }
    return gridZones;
}


//getGridZoneOfClickEvent();

function getGridZoneOfClickEvent() {
    var gridClicked;
    for (var x = 1; x < gridZones.length; x++) {
        if (xpos > gridZones[x].xL && xpos <= gridZones[x].xR && ypos > gridZones[x].yT && ypos <= gridZones[x].yB) {
            console.log("You clicked on: " + gridZones[x].gridId);
            gridClicked = gridZones[x].gridNumber;
        }
    }
    crimeSolved(gridClicked);
}

//********************************************* Crime Solved ************************************//

function crimeSolved(gridNo) {
    for (var i = 0; i < crimes.length; i++) {
        if (gridNo == crimes[i].gridNum) {
            var crimeAlert = document.getElementsByClassName(`crimeAlert-${crimes[i].gridNum}`)[0];
            innerBreaking.removeChild(crimeAlert);
            crimes[i].endTime = (new Date()).getTime();
            var timeTaken = crimes[i].endTime - crimes[i].startTime;
            var newScore = (((15000 - timeTaken) * crimes[i].distance) * remedyLevel) / 500;
            score = score + newScore;
            var remedyUsed = remedyLevel;
            currentScoreScore.innerHTML = score.toFixed(2);
            listToCurrentJobs(crimes[i], remedyUsed, i);
        }
    }

}

// moves the crime to current jobs
function listToCurrentJobs(crime, remedy, number) {
    var timeToExpire;
    var textContent = innerCurrentJobs.innerHTML;
    innerCurrentJobs.innerHTML = textContent + `<p class="crimeAlert-${crime.gridName}">` + crime.gridName + '</p>'
    switch (remedy) {
        case 1:
            timeToExpire = 5000;
            break;
        case 2:
            timeToExpire = 12000;
            break;
        case 3:
            timeToExpire = 16000;
            break;
        case 4:
            timeToExpire = 20000;
            break;
        case 5:
            timeToExpire = 30000;
            break;
    }
    setTimeout(function () {
        crimes.splice(number, 1);
        var crimeAlert = document.getElementsByClassName(`crimeAlert-${crime.gridName}`)[0];
        innerCurrentJobs.removeChild(crimeAlert);
    }, timeToExpire);


}

//*********************************************** Trigger Crime *************************************************//



// checks to make sure no crime in progress, then sets a crime in a random zone
// of random severity, between 3 and 6 seconds.
function triggerCrime() {
    if (cancelTimer == false) {
        var randomTime = Math.floor((Math.random() * (5000)) + 1000);
        var randomZone = Math.floor((Math.random() * 64) + 1);
        var randomSeverity = Math.floor((Math.random() * 5) + 1);
        var gridName = gridZones[randomZone].gridId;
        var gridNumber = gridZones[randomZone].gridNumber;
        if (gridZones[randomZone].gridActive == false) {
            var distance = getDistance(randomZone);
            crimeObj = {
                gridName: gridName,
                severity: randomSeverity,
                startTime: (new Date()).getTime(),
                endTime: 0,
                distance: distance,
                gridNum: gridNumber,
            };
            gridZones[randomZone].gridActive = true;
            var textContent = innerBreaking.innerHTML;
            crimes.push(crimeObj);
            innerBreaking.innerHTML = textContent + `<p class="crimeAlert-${crimeObj.gridNum}">` + crimeObj.gridName + '</p>';
        }
        setTimeout(triggerCrime, randomTime);
    }
}



// **************************************** trying to copy icon **********************************************//


//*******************************************Icon Movement******************************************************//
var copCounter = 0;
var detectiveCounter = 0;
var squadCarCounter = 0;
var helicopterCounter = 0;
var tankCounter = 0;
//******************************************* Individual Remedy ************************************************//


function getClickPosition2(e) {
    var xposition = e.clientX;
    var yposition = e.clientY;
    xpos = xposition;
    ypos = yposition;
    console.log("cop clicked");
    copCounter = copCounter + 1;
    remedyLevel = 1;
    cop.style.borderColor = "green";
    cop.style.borderStyle = "solid";
    cop.style.borderWidth = "5px";
    detective.style.border = null;
    squadCar.style.border = null;
    helicopter.style.border = null;
    tank.style.border = null;
    if (copCounter == 5) {
        cop.style.filter = "grayscale(100%)";
        setTimeout(returnCop, 5000);
    }
}

function returnCop() {
    cop.style.filter = "grayscale(0%)";
    copCounter = 0;
}

function getClickPosition3(e) {
    var xposition = e.clientX;
    var yposition = e.clientY;
    xpos = xposition;
    ypos = yposition;
    console.log("detective clicked");
    detectiveCounter = detectiveCounter + 1;
    remedyLevel = 2;
    detective.style.borderColor = "green";
    detective.style.borderStyle = "solid";
    detective.style.borderWidth = "5px";
    cop.style.border = null;
    squadCar.style.border = null;
    helicopter.style.border = null;
    tank.style.border = null;
    if (detectiveCounter == 5) {
        detective.style.filter = "grayscale(100%)";
        setTimeout(returnDetective, 10000);
    }
}

function returnDetective() {
    detective.style.filter = "grayscale(0%)";
    detectiveCounter = 0;
}

function getClickPosition4(e) {
    var xposition = e.clientX;
    var yposition = e.clientY;
    xpos = xposition;
    ypos = yposition;
    console.log("squadCar clicked");
    squadCarCounter = squadCarCounter + 1;
    remedyLevel = 3;
    squadCar.style.borderColor = "green";
    squadCar.style.borderStyle = "solid";
    squadCar.style.borderWidth = "5px";
    detective.style.border = null;
    cop.style.border = null;
    helicopter.style.border = null;
    tank.style.border = null;
    if (squadCarCounter == 3) {
        squadCar.style.filter = "grayscale(100%)";
        setTimeout(returnSquadCar, 15000);
    }
}

function returnSquadCar() {
    squadCar.style.filter = "grayscale(0%)";
    squadCarCounter = 0;
}

function getClickPosition5(e) {
    var xposition = e.clientX;
    var yposition = e.clientY;
    xpos = xposition;
    ypos = yposition;
    console.log("helicopter clicked");
    helicopterCounter = helicopterCounter + 1;
    remedyLevel = 4;
    helicopter.style.borderColor = "green";
    helicopter.style.borderStyle = "solid";
    helicopter.style.borderWidth = "5px";
    detective.style.border = null;
    squadCar.style.border = null;
    cop.style.border = null;
    tank.style.border = null;
    if (helicopterCounter == 2) {
        helicopter.style.filter = "grayscale(100%)";
        setTimeout(returnHelicopter, 20000);
    }
}

function returnHelicopter() {
    helicopter.style.filter = "grayscale(0%)";
    helicopterCounter = 0;
}

function getClickPosition6(e) {
    var xposition = e.clientX;
    var yposition = e.clientY;
    xpos = xposition;
    ypos = yposition;
    console.log("tank clicked");
    tankCounter = tankCounter + 1;
    remedyLevel = 5;
    tank.style.borderColor = "green";
    tank.style.borderStyle = "solid";
    tank.style.borderWidth = "5px";
    detective.style.border = null;
    squadCar.style.border = null;
    helicopter.style.border = null;
    cop.style.border = null;
    tank.style.filter = "grayscale(100%)";
    setTimeout(returnTank, 30000);
}

function returnTank() {
    tank.style.filter = "grayscale(0%)";
    tankCounter = 0;
}

//**************************************** Housekeeping *********************************************************//

function getDistance(randomZone) {
    if (randomZone <= 8) {
        return 8;
    } else if (randomZone <= 16) {
        return 7;
    } else if (randomZone <= 24) {
        return 6;
    } else if (randomZone <= 32) {
        return 5;
    } else if (randomZone <= 40) {
        return 4;
    } else if (randomZone <= 48) {
        return 3;
    } else if (randomZone <= 56) {
        return 2;
    } else {
        return 1;
    }
}


function setNamesToGridZones() {
    gridZones[1].gridId = "Art Center";
    gridZones[2].gridId = "ManziMoCoCo";
    gridZones[3].gridId = "Gila";
    gridZones[4].gridId = "The Museum";
    gridZones[5].gridId = "Centennial Hall";
    gridZones[6].gridId = "Cochise";
    gridZones[7].gridId = "Mcclelland Park";
    gridZones[8].gridId = "The Southwest Corner";
    gridZones[9].gridId = "CAPLA";
    gridZones[10].gridId = "Harvill";
    gridZones[11].gridId = "Yuma";
    gridZones[12].gridId = "Chavez";
    gridZones[13].gridId = "Social Sciences";
    gridZones[14].gridId = "Saguaro / Yavapai";
    gridZones[15].gridId = "Performing Arts Center";
    gridZones[16].gridId = "Sixth St Garage";
    gridZones[17].gridId = "ECE";
    gridZones[18].gridId = "Civil Engineering";
    gridZones[19].gridId = "Behind the Bookstore";
    gridZones[20].gridId = "The Bookstore";
    gridZones[21].gridId = "Nugent";
    gridZones[22].gridId = "Shantz";
    gridZones[23].gridId = "Bannister";
    gridZones[24].gridId = "Highland Commons";
    gridZones[25].gridId = "Little Chapel";
    gridZones[26].gridId = "Pima";
    gridZones[27].gridId = "Second St. Garage";
    gridZones[28].gridId = "Student Union";
    gridZones[29].gridId = "Koffler";
    gridZones[30].gridId = "Bio Sciences";
    gridZones[31].gridId = "La Paz";
    gridZones[32].gridId = "Apache Santa Cruz";
    gridZones[33].gridId = "Fraternity Row";
    gridZones[34].gridId = "LSB";
    gridZones[35].gridId = "Steward Observatory";
    gridZones[36].gridId = "Psychology / Sonnet";
    gridZones[37].gridId = "Main Library";
    gridZones[38].gridId = "Bear Down Field";
    gridZones[39].gridId = "The Stadium";
    gridZones[40].gridId = "The Stadium";
    gridZones[41].gridId = "Warren Apartments";
    gridZones[42].gridId = "Teaching Center";
    gridZones[43].gridId = "Hillebrand Stadium West Parking";
    gridZones[44].gridId = "Flandrau";
    gridZones[45].gridId = "Meniel";
    gridZones[46].gridId = "Cherry Ave Garage";
    gridZones[47].gridId = "Mirror Lab";
    gridZones[48].gridId = "Mirror Lab";
    gridZones[49].gridId = "Administration near Speedway / Campbell";
    gridZones[50].gridId = "Transitional Office";
    gridZones[51].gridId = "Hillenbrand Stadium";
    gridZones[52].gridId = "Gitting / Eller Dance";
    gridZones[53].gridId = "McKale Center";
    gridZones[54].gridId = "McKale Center";
    gridZones[55].gridId = "Clements";
    gridZones[56].gridId = "South of McKale";
    gridZones[57].gridId = "Rawls / Eller / Dirtbags / Taco Bell";
    gridZones[58].gridId = "Police Station";
    gridZones[59].gridId = "Tennis Center";
    gridZones[60].gridId = "East Mall";
    gridZones[61].gridId = "Richard Jefferson Gymnasium";
    gridZones[62].gridId = "Roby Gymnastics / Hillenbrand Aquatic Center";
    gridZones[63].gridId = "South of the Aquatic Center";
    gridZones[64].gridId = "Campbell / Sixth Ave Area";
}


//        if (xpos > gridZones[x].xL && xpos <= gridZones[x].xR && ypos > gridZones[x].yT && ypos <= gridZones[x].yB) {

//let timerId = setInterval(() => console.log('tick'), 2000);
//
//setTimeout(() => { clearInterval(timerId); console.log('stop'); }, 10000);
//
//
//var objArray = [];
//objArray[0] = {xL : 100, xR: 200, yT: 25, yB: 50};
//objArray[1] = {xL : 200, xR: 300, yT: 25, yB: 50};
//
//
//for (var i = 0; i < 2; i++) {
//    console.log(objArray[i]);
//    console.log(objArray[i].xL);
//}









//window.addEventListener("click", function(event) {
//var x = event.pageX - (map.offsetLeft + map.parentElement.offsetLeft);
//var y = event.pageY - (map.offsetTop + map.parentElement.offsetTop);
//console.log("relative x=" + x, "relative y" + y);
//});


// use a loop through crimes[i][2] to get location for every entry;


//function whichElement(e) {
//  var targ;
//  if (!e) {
//    var e = window.event;
//  }
//  if (e.target) {
//    targ = e.target;
//  } else if (e.srcElement) {
//    targ = e.srcElement;
//  }
//  var tname;
//  tname = targ.tagName;
//  console.log("You clicked on a " + tname + " element.");
//}





//function enterDroppable(elem) {
//    elem.style.background = 'pink';
//}
//
//function leaveDroppable(elem) {
//    elem.style.background = '';
//}
