// 5. Unit Conversion
// a. Convert 42 inches to feet
let inches = 42;
let feet = inches / 12;
console.log(`${inches} inches = ${feet.toFixed(2)} feet`);

// b. Convert Rectangular Plot (60 ft x 40 ft) to meters
let lengthFeet = 60;
let widthFeet = 40;
let feetToMeters = 0.3048;
let lengthMeters = lengthFeet * feetToMeters;
let widthMeters = widthFeet * feetToMeters;
console.log(`Plot Size: ${lengthFeet}x${widthFeet} feet = ${lengthMeters.toFixed(2)}x${widthMeters.toFixed(2)} meters`);

// c. Calculate Area of 25 Such Plots in Acres
let singlePlotAreaSqMeters = lengthMeters * widthMeters;
let totalAreaSqMeters = singlePlotAreaSqMeters * 25;
let metersToAcres = 0.000247105;
let totalAreaAcres = totalAreaSqMeters * metersToAcres;
console.log(`Total area of 25 plots: ${totalAreaAcres.toFixed(4)} acres`);