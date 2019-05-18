function validate() {
    let checkboxElement = $('#company');

    function toggleCompanyInfo() {
        if (checkboxElement.is(':checked')) {
            $('#companyInfo').css('display', 'block');
        }
        else {
            $('#companyInfo').css('display', 'none');
        }
    }

    function validateFields() {
        let allValid = true;

        let usernameInputElement = $('#username');
        let passwordInputElement = $('#password');
        let confirmPasswordInputElement = $('#confirm-password');
        let emailInputElement = $('#email');

        if (!usernameInputElement.val().match('^[a-zA-Z\\d]{3,20}$')) {
            usernameInputElement.css('border-color', 'red');
            allValid = false;
        }
        else {
            usernameInputElement.css('border', 'none');
        }

        if (!passwordInputElement.val().match('^\\w{5,15}$')) {
            passwordInputElement.css('border-color', 'red');
            allValid = false;
        }
        else {
            passwordInputElement.css('border', 'none');
        }

        if (confirmPasswordInputElement.val().match('^\\w{5,15}$') && passwordInputElement.val() === confirmPasswordInputElement.val()) {
            confirmPasswordInputElement.css('border', 'none');
        }
        else {
            confirmPasswordInputElement.css('border-color', 'red');
            passwordInputElement.css('border', '1px solid');
            passwordInputElement.css('border-color', 'red');
            allValid = false;
        }

        if (!emailInputElement.val().match('@.*\\.')) {
            emailInputElement.css('border-color', 'red');
            allValid = false;
        }
        else {
            emailInputElement.css('border', 'none');
        }

        if (checkboxElement.is(':checked')) {
            let companyNumberElement = $('#companyNumber');
            let companyNumber = Number(companyNumberElement.val());

            if (companyNumber < 1000 || companyNumber > 9999) {
                companyNumberElement.css('border-color', 'red');
                allValid = false;
            }
            else {
                companyNumberElement.css('border', 'none');
            }
        }

        if (allValid) {
            $('#valid').css('display', 'block');
        }

        console.log(allValid);
        console.log(confirmPasswordInputElement.val().match('^.{5,15}$'));
    }

    checkboxElement.change(toggleCompanyInfo);

    $('#submit').click(function (event) {
        event.preventDefault();
        validateFields();
    });
}
