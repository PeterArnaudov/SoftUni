function solve(day, service, hour) {
    let result;

    if (service == "Fitness") {
        if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") {
            if (hour >= 8 && hour <= 15) {
                result = 5;
            }
            else {
                result = 7.5;
            }
        }
        else if (day == "Saturday" || day == "Sunday") {
            result = 8;
        }
    }
    else if (service == "Sauna") {
        if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") {
            if (hour >= 8 && hour <= 15) {
                result = 4;
            }
            else {
                result = 6.5;
            }
        }
        else if (day == "Saturday" || day == "Sunday") {
            result = 7;
        }
    }
    else if (service == "Instructor") {
        if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday") {
            if (hour >= 8 && hour <= 15) {
                result = 10;
            }
            else {
                result = 12.5;
            }
        }
        else if (day == "Saturday" || day == "Sunday") {
            result = 15;
        }
    }

    console.log(result);
}