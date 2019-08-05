function attachEvents() {
    $('#submit').click(submit);

    function submit() {
        let getRequest = $.get('https://judgetests.firebaseio.com/locations.json');

        getRequest.then(data => {
            let inputLocation = $('#location').val();
            data = data.filter(x => x.name === inputLocation)[0];

            let currentForecastRequest = $.get(`https://judgetests.firebaseio.com/forecast/today/${data.code}.json`);
            let threeDayForecastRequest = $.get(`https://judgetests.firebaseio.com/forecast/upcoming/${data.code}.json`);

            Promise.all([currentForecastRequest, threeDayForecastRequest])
                .then(displayForecast)
                .catch(displayError);
        });
        getRequest.catch(displayError);
    }
    
    function displayForecast([current, upcoming]) {
        $('#current span').remove();
        $('#upcoming span').remove();

        $('#forecast').css('display', 'block');

        let degreesSymbol = '&#176';
        let currentCondition = current.forecast.condition === 'Sunny' ? '&#x2600'
            : current.forecast.condition === 'Partly sunny' ? '&#x26C5'
                : current.forecast.condition === 'Overcast' ? '&#x2601'
                    : current.forecast.condition === 'Rain' ? '&#x2614'
                        : 'Invalid condition';


        let currentForecastDiv = $('#current');

        currentForecastDiv.append($(`<span class="condition symbol">${currentCondition}</span>`));
        currentForecastDiv.append($('<span class="condition"></span>')
            .append($(`<span class="forecast-data">${current.name}</span>`))
            .append($(`<span class="forecast-data">${current.forecast.low}${degreesSymbol}/${current.forecast.high}${degreesSymbol}</span>`))
            .append($(`<span class="forecast-data">${current.forecast.condition}</span>`)));

        let upcomingForecastDiv = $('#upcoming');

        upcoming.forecast.forEach(x => {
            let upcomingSpan = $('<span class="upcoming"></span>');

            let symbol = x.condition === 'Sunny' ? '&#x2600'
                : x.condition === 'Partly sunny' ? '&#x26C5'
                    : x.condition === 'Overcast' ? '&#x2601'
                        : x.condition === 'Rain' ? '&#x2614'
                            : 'Invalid condition';

            upcomingSpan.append($(`<span class="symbol">${symbol}</span>`));
            upcomingSpan.append($(`<span class="forecast-data">${x.low}${degreesSymbol}/${x.high}${degreesSymbol}</span>`));
            upcomingSpan.append($(`<span class="forecast-data">${x.condition}</span>`));

            upcomingForecastDiv.append(upcomingSpan);
        });
    }

    function displayError() {
        $('#forecast').css('display', 'block');
        $('#forecast').text('Error');
    }
}