let numbers = Array.from({ length: 5 }, () => Math.floor(Math.random() * 90) + 10);
let sum = numbers.reduce((a, b) => a + b, 0);
let average = sum / numbers.length;
console.log("Numbers:", numbers, "Sum:", sum, "Average:", average);