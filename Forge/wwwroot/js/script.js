﻿const backgroundCoverData = [
    {
        coverImage: "https://wallpapercave.com/wp/wp4162204.jpg",
        title: "Red Dead Redemption II",
        description: "Immersive journey through the Wild West of 1899. Play as Arthur Morgan in a morally intricate narrative," 
        +" exploring a vast open world teeming with life and stunning landscapes."
    },
    {
        coverImage: "https://wallpapercave.com/wp/wp4251247.jpg",
        title: "Spider Man 2",
        description: "Exhilarating action-adventure game, delivers a dynamic open-world experience." 
        +"Swing through the iconic streets of New York City, combat foes with enhanced abilities, and unravel a captivating narrative."
    },
    {
        coverImage: "https://wallpapercave.com/wp/wp9682062.jpg",
        title: "Age Of Empire IV",
        description: "Embark on an epic journey through history in Age of Empires IV. Command diverse civilizations, lead armies into monumental battles, forge"
        +"alliances, and shape the course of history with cutting - edge graphics, strategic depth, and a rich blend of historical accuracy and immersive gameplay."
    }
]

function loadCover(backgroundCoverId) {
    const cover = document.getElementById("cover");
    const gameTitle = document.getElementById("gameTitle");
    const gameDescription = document.getElementById("gameDescription");

    cover.style.backgroundImage = "url('" + backgroundCoverData[backgroundCoverId].coverImage + "')";
    gameTitle.innerHTML = backgroundCoverData[backgroundCoverId].title;
    gameDescription.innerHTML = backgroundCoverData[backgroundCoverId].description;
}

(function setUnrealEngineData() {
    const engineVersion = document.getElementById("engineVersion");
    const engineTitle = document.getElementById("engineName");
    const engineHeading = document.getElementById("engineHeading");
    const engineDescription = document.getElementById("engineDescription");

    engineVersion.innerHTML = "5.3";
    engineTitle.innerHTML = "Unreal Engine";
    engineHeading.innerHTML = "Unreal Engine 5.3 Released";
    engineDescription.innerHTML = "Get your hands on Unreal Engine 5.3 today. With this release, developers will gain access to expanded"+ 
    "functionality in UE5's core rendering, development iteration, and virtual production workflows."+
    "Plus, explore a slew of experimental rendering, animation, and simulation features!";

    engineVersion.classList.add("engineBackgroundAnimation");
    engineName.classList.add("engineBackgroundAnimation");

})();
