const n = parseInt(process.argv[2]); // Read command-line argument

if (isNaN(n) || n < 0) {
    console.log("Please provide a valid non-negative number.");
    process.exit(1);
}

console.log(`Table of Powers of 2 up to 2^${n} or 256:`);

let power = 1;
for (let i = 0; i <= n && power <= 256; i++) {
    console.log(`2^${i} = ${power}`);
    power *= 2;
}
