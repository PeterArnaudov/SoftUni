function result(name, age, weight, height) {
    let bmi = Math.round(weight / Math.pow(height/ 100, 2));

    let patientChart = {
        name: name,
        personalInfo: {
            age: age,
            weight: weight,
            height: height
        },
        BMI: bmi,
        status: bmi < 18.5 ? 'underweight' : bmi < 25 ? 'normal' : bmi < 30 ? 'overweight' : 'obese',
    };

    if (patientChart.status == 'obese') {
        patientChart['recommendation'] = 'admission required'
    }

    return patientChart;
}