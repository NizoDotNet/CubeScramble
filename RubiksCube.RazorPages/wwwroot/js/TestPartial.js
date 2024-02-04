const URI = "/cube";
const scrambleEl = document.querySelector(".scramble");
let cube = GetCube();
ShowScrambleFromText(JSON.stringify(cube.cubeSides));
let T = null;
let IsPressed = false;
let S = new Date;

let up = onkeyup = e => {
    if (up) {
        S = new Date;
        T = setInterval("a.innerHTML=(new Date-S)/1e3");
    }
    else {
        clearInterval(T);
        RecordScramble();
        cube = GetCube();
        ShowScramble();
    }
    up = !up;
}

function GetCube() {
    return fetch(URI)
        .then(res => res.json())
}
function GetColor(c) {
    switch (c) {
        case 'w':
            return 'white';
        case 'y':
            return 'yellow';
        case 'g':
            return 'green';
        case 'b':
            return 'blue';
        case 'r':
            return 'red';
        case 'o':
            return 'orange';
    }
}
function ShowScrambleFromText(cubeText) {
    const cubeJson = JSON.parse(cubeText);
    console.log("i am helping");
    console.log(cubeJson);
    whside.innerHTML = "";
    orside.innerHTML = "";
    grside.innerHTML = "";
    redside.innerHTML = "";
    blside.innerHTML = "";
    ylside.innerHTML = "";
    for (let i = 0; i < 3; i++) {
        for (let j = 0; j < 3; j++) {
            let color = GetColor(cubeJson.whiteSide[i][j]);
            console.log(color)
            whside.innerHTML += `<div style="background-color: ${color};"></div>`
            color = GetColor(cubeJson.orangeSide[i][j]);
            orside.innerHTML += `<div style="background-color: ${color};"></div>`
            color = GetColor(cubeJson.greenSide[i][j]);
            grside.innerHTML += `<div style="background-color: ${color};"></div>`
            color = GetColor(cubeJson.redSide[i][j]);
            redside.innerHTML += `<div style="background-color: ${color};"></div>`
            color = GetColor(cubeJson.blueSide[i][j]);
            blside.innerHTML += `<div style="background-color: ${color};"></div>`
            color = GetColor(cubeJson.yellowSide[i][j]);
            ylside.innerHTML += `<div style="background-color: ${color};"></div>`
        }
    }
}
function RecordScramble() {
    cube.then(data => {
        fetch(URI, {
            method: "POST",
            body: JSON.stringify({
                time: a.innerHTML,
                scramble: scrambleEl.innerHTML,
                cubeJson: JSON.stringify(data.cubeSides),
                speedCuberId: "id"
            }),
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        }).catch(e => console.log(`Your shit err: ${e}`))
    });

}
