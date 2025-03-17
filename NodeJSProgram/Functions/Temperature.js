function convertTemperature(choice, temp) {
    switch (choice) {
        case "1": // Celsius to Fahrenheit
            if (temp >= 0 && temp <= 100) {
                return `${temp}°C = ${(temp * 9 / 5 + 32).toFixed(2)}°F`;
            } else {
                return "Temperature out of range (0°C - 100°C)";
            }
        case "2": // Fahrenheit to Celsius
            if (temp >= 32 && temp <= 212) {
                return `${temp}°F = ${((temp - 32) * 5 / 9).toFixed(2)}°C`;
            } else {
                return "Temperature out of range (32°F - 212°F)";
            }
        default:
            return "Invalid Choice";
    }
}