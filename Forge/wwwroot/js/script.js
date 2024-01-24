const backgroundCoverData = [
    {
        coverImage: "https://wallpapercave.com/wp/wp4162204.jpg",
        title: "Red Dead Redemption II",
        description: "Immersive journey through the Wild West of 1899. Play as Arthur Morgan in a morally intricate narrative,"
            + " exploring a vast open world teeming with life and stunning landscapes."
    },
    {
        coverImage: "https://wallpapercave.com/wp/wp4251247.jpg",
        title: "Spider Man 2",
        description: "Exhilarating action-adventure game, delivers a dynamic open-world experience."
            + "Swing through the iconic streets of New York City, combat foes with enhanced abilities, and unravel a captivating narrative."
    },
    {
        coverImage: "https://wallpapercave.com/wp/wp9682062.jpg",
        title: "Age Of Empire IV",
        description: "Embark on an epic journey through history in Age of Empires IV. Command diverse civilizations, lead armies into monumental battles, forge"
            + "alliances, and shape the course of history with cutting - edge graphics, strategic depth, and a rich blend of historical accuracy and immersive gameplay."
    }
];



//Function to set background cover data with a 5-second delay 
(async function setBackgroundCover() {
    const cover = document.getElementById("cover");
    const gameTitle = document.getElementById("gameTitle");
    const gameDescription = document.getElementById("gameDescription");

    //Loop through the backgroundCoverData array
    for (let dataPointer = 0; dataPointer < backgroundCoverData.length; dataPointer++) {
        cover.style.backgroundImage = "url('" + backgroundCoverData[dataPointer].coverImage + "')";
        gameTitle.textContent = backgroundCoverData[dataPointer].title;
        gameDescription.textContent = backgroundCoverData[dataPointer].description;

        //If it's the last element, reset the dataPointer to start from the beginning
        if (dataPointer === backgroundCoverData.length - 1) {
            dataPointer = -1;
        }

        //5 seconds delay using a Promise and timeout
        await new Promise(waitState => setTimeout(waitState, 5000));
    }

})();

//Function to set Unreal Engine data
(function setUnrealEngineData() {
    const engineVersion = document.getElementById("unrealEngineVersion");
    const engineTitle = document.getElementById("unrealEngineName");
    const engineHeading = document.getElementById("unrealEngineHeading");
    const engineDescription = document.getElementById("unrealEngineDescription");

    //Insert data
    engineVersion.innerHTML = "5.3";
    engineTitle.innerHTML = "Unreal Engine";
    engineHeading.innerHTML = "Unreal Engine 5.3 Released";
    engineDescription.innerHTML = "Get your hands on Unreal Engine 5.3 today. With this release, developers will gain access to expanded"+ 
    "functionality in UE5's core rendering, development iteration, and virtual production workflows."+
    "Plus, explore a slew of experimental rendering, animation, and simulation features!";

    //Add CSS class for animation
    engineVersion.classList.add("engineBackgroundAnimation");
    engineTitle.classList.add("engineBackgroundAnimation");

})();

//Function to set Unity Engine data
(function setUnityEngineData() {
    const engineVersion = document.getElementById("unityEngineVersion");
    const engineTitle = document.getElementById("unityEngineName");
    const engineHeading = document.getElementById("unityEngineHeading");
    const engineDescription = document.getElementById("unityEngineDescription");

    //Insert Data
    engineVersion.textContent = "2022.2";
    engineTitle.innerHTML = "Unity Engine";
    engineHeading.innerHTML = "Unleash your creativity";
    engineDescription.innerHTML = "Unity gives you the control to create some of gaming’s most diverse genres and styles, whether 2D pixel art, photo-real 3D graphics, single-player or multiplayer. " +
        "Unity’s industry-leading engine provides tools to create and operate amazing games and other real-time interactive " +
        "experiences and publish them to a wide range of devices. You can work on Windows, Mac, and Linux.";

    engineVersion.classList.add("engineBackgroundAnimation");
    engineTitle.classList.add("engineBackgroundAnimation");
})();

//Function to redirect to the original website of the engine
function redirectToEngine(number) {

    let engineRedirectionLink = "";
    //If the number passed to this function is 1, which represents Unreal Engine
    if (number === 1) {

        engineRedirectionLink = "https://www.unrealengine.com/en-US/";
    }
    //If the number passed to this function is 2, which represents Unity Engine
    else if (number === 2) {

        engineRedirectionLink = "https://unity.com/";
    }
    else {
        console.log("The number being passed to the function is incorrect.");
    }

    if (engineRedirectionLink != "") {
        var newTab = window.open(engineRedirectionLink, '_blank');
        newTab.focus();
    }
}

function displayGameContent(gameID) {

    let url = '/ViewGameContent/GameContent?GameID=' + gameID;
    window.location.href = url;
}

function systemRequirement() {
    var systemRequirementButton = document.getElementsByClassName("systemRequirementButton");
    var x;

    for (x = 0; x < systemRequirementButton.length; x++) {

        systemRequirementButton[x].addEventListener("click", function () {
            this.classList.toggle("active");
            let requirementPanel = this.nextElementSibling;

            if (requirementPanel.style.maxHeight) {
                requirementPanel.style.maxHeight = null;
            }
            else {
                requirementPanel.style.maxHeight = requirementPanel.scrollHeight + "px";
            }
        });
    }
};

