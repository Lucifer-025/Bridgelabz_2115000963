function numberToPlaceValue(num) {
    const placeValues = {
        1: "Unit",
        10: "Ten",
        100: "Hundred",
        1000: "Thousand",
        10000: "Ten Thousand",
        100000: "Lakh"
    };
    return placeValues[num] || "Invalid Input";
}
