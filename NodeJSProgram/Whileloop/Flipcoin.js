function flipCoin() {
    return Math.random() < 0.5 ? "Heads" : "Tails";
}

let heads = 0, tails = 0;

while (heads < 11 && tails < 11) {
    let result = flipCoin();
    if (result === "Heads") {
        heads++;
    } else {
        tails++;
    }
    console.log(`Flipped: ${result} | Heads: ${heads}, Tails: ${tails}`);
}

console.log(`Winner: ${heads === 11 ? "Heads" : "Tails"}`);
