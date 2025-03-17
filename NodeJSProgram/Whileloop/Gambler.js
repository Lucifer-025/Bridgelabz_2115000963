let money = 100;
let bets = 0;
let wins = 0;

while (money > 0 && money < 200) {
    bets++;
    if (Math.random() < 0.5) {
        money++;  // Win ₹1
        wins++;
    } else {
        money--;  // Lose ₹1
    }
}

console.log(`Final Money: ₹${money}`);
console.log(`Total Bets Placed: ${bets}`);
console.log(`Total Wins: ${wins}`);
