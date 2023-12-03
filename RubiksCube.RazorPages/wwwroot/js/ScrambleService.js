const URI = "/cube";
const scrambleEl = document.querySelector(".scramble");
let cube = GetCube();
ShowScramble();
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

function ShowScramble() {
    cube.then(data => {
        scrambleEl.innerHTML = data.scramble;

        console.log(data.cubeSides.whiteSide);
        whside.innerHTML = "";
        orside.innerHTML = "";
        grside.innerHTML = "";
        redside.innerHTML = "";
        blside.innerHTML = "";
        ylside.innerHTML = "";

        for (let i = 0; i < 3; i++) {
            for (let j = 0; j < 3; j++) {
                let color = GetColor(data.cubeSides.whiteSide[i][j]);
                whside.innerHTML += `<div style="background-color: ${color};"></div>`
                color = GetColor(data.cubeSides.orangeSide[i][j]);
                orside.innerHTML += `<div style="background-color: ${color};"></div>`
                color = GetColor(data.cubeSides.greenSide[i][j]);
                grside.innerHTML += `<div style="background-color: ${color};"></div>`
                color = GetColor(data.cubeSides.redSide[i][j]);
                redside.innerHTML += `<div style="background-color: ${color};"></div>`
                color = GetColor(data.cubeSides.blueSide[i][j]);
                blside.innerHTML += `<div style="background-color: ${color};"></div>`
                color = GetColor(data.cubeSides.yellowSide[i][j]);
                ylside.innerHTML += `<div style="background-color: ${color};"></div>`
            }
        }
    });

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
