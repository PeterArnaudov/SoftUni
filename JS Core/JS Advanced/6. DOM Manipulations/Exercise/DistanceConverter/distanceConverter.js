function attachEventsListeners() {
    function convert() {
        let inputNumber = Number($('#inputDistance').val());
        let inputType = $('#inputUnits').val();
        let outputType = $('#outputUnits').val();

        if (inputType == 'km') {
            inputNumber *= 1000;
        }
        else if (inputType == 'cm') {
            inputNumber *= 0.01;
        }
        else if (inputType == 'mm') {
            inputNumber *= 0.001;
        }
        else if (inputType == 'mi') {
            inputNumber *= 1609.34;
        }
        else if (inputType == 'yrd') {
            inputNumber *= 0.9144;
        }
        else if (inputType == 'ft') {
            inputNumber *= 0.3048;
        }
        else if (inputType == 'in') {
            inputNumber *= 0.0254;
        }

        let outputNumber;

        if (outputType == 'km') {
            outputNumber = inputNumber / 1000;
        }
        else if (outputType == 'm') {
            outputNumber = inputNumber;
        }
        else if (outputType == 'cm') {
            outputNumber = inputNumber / 0.01;
        }
        else if (outputType == 'mm') {
            outputNumber = inputNumber / 0.001;
        }
        else if (outputType == 'mi') {
            outputNumber = inputNumber / 1609.34;
        }
        else if (outputType == 'yrd') {
            outputNumber = inputNumber / 0.9144;
        }
        else if (outputType == 'ft') {
            outputNumber = inputNumber / 0.3048;
        }
        else if (outputType == 'in') {
            outputNumber = inputNumber / 0.0254;
        }

        $('#outputDistance').val(outputNumber);
    }

    $('#convert').click(convert);
}
