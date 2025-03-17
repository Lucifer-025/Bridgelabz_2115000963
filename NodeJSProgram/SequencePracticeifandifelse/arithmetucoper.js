function arithmeticOperations(a, b, c) {
    let results = {
        "a + b * c": a + b * c,
        "a % b + c": a % b + c,
        "c + a / b": c + a / b,
        "a * b + c": a * b + c
    };

    let maxResult = Math.max(...Object.values(results));
    let minResult = Math.min(...Object.values(results));

    console.log("Results:", results);
    console.log("Maximum Value:", maxResult);
    console.log("Minimum Value:", minResult);
}
