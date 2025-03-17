let numbers = Array.from({ length: 5 }, () => Math.floor(Math.random() * 900) + 100);
let min = Math.min(...numbers);
let max = Math.max(...numbers);
console.log("Numbers:", numbers, "Min:", min, "Max:", max);