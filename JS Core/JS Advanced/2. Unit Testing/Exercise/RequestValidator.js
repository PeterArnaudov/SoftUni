function validateRequest(request) {
    let validMethod = request.method == 'GET' ||
        request.method == 'POST' ||
        request.method == 'DELETE' ||
        request.method == 'CONNECT';

    let validURI = !request.hasOwnProperty('uri') ? false : request.uri.match(/^\*$|([a-z\d\.]+)+/g) == request.uri;

    let validVersion = request.version === 'HTTP/0.9' ||
        request.version === 'HTTP/1.0' ||
        request.version === 'HTTP/1.1' ||
        request.version === 'HTTP/2.0';

    let specialCharacters = new RegExp('[<>\\\\&\'"]', 'g');
    let validMessage = !request.hasOwnProperty('message') ? true : specialCharacters.test(request.message);

    if (!validMethod) {
        throw new Error('Invalid request header: Invalid Method');
    }
    else if (!validURI) {
        throw new Error('Invalid request header: Invalid URI');
    }
    else if (!validVersion) {
        throw new Error('Invalid request header: Invalid Version');
    }
    else if (validMessage) {
        throw new Error('Invalid request header: Invalid Message');
    }

    return request;
}