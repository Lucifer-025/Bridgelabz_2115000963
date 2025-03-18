function rollDie() {
    return Math.floor(Math.random() * 6) + 1;
}

function simulateDieRolls() {
    let dieCounts = { 1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0 };
    let maxReached = false;

    while (!maxReached) {
        let roll = rollDie();
        dieCounts[roll]++;
        
        if (dieCounts[roll] === 10) {
            maxReached = true;
        }
    }

    console.log("Die Roll Counts:", dieCounts);

    let maxValue = Math.max(...Object.values(dieCounts));
    let minValue = Math.min(...Object.values(dieCounts));

    let maxNumber = Object.keys(dieCounts).find(key => dieCounts[key] === maxValue);
    let minNumber = Object.keys(dieCounts).find(key => dieCounts[key] === minValue);

    console.log(`Number that appeared maximum times: ${maxNumber} (${maxValue} times)`);
    console.log(`Number that appeared minimum times: ${minNumber} (${minValue} times)`);
}

simulateDieRolls();

