(() => {
    function sendQuestion () {
        let question = document.getElementsByTagName('textarea')[0].value;
        let name = document.getElementsByTagName('input')[0].value;

        if (!name) {
            name = 'Anonymous';
        }

        document.getElementsByTagName('textarea')[0].value = '';
        document.getElementsByTagName('input')[0].value = '';

        let questionDiv = $('<div>');
        questionDiv.addClass('pendingQuestion');

        let imgProfile = $('<img>');
        imgProfile.attr('src', './images/user.png');
        imgProfile.attr('width', 32);
        imgProfile.attr('height', 32);

        let spanName = $('<span>');
        spanName.text(name);

        let questionParagraph = $('<p>');
        questionParagraph.text(question);

        let buttonsDiv = $('<div>');
        buttonsDiv.addClass('actions');
        let archiveButton = $('<button>');
        archiveButton.addClass('archive');
        archiveButton.text('Archive');
        archiveButton.click(archiveQuestion);
        let openButton = $('<button>');
        openButton.addClass('open');
        openButton.text('Open');
        openButton.click(openQuestion);
        buttonsDiv.append(archiveButton);
        buttonsDiv.append(openButton);

        questionDiv.append(imgProfile);
        questionDiv.append(spanName);
        questionDiv.append(questionParagraph);
        questionDiv.append(buttonsDiv);

        $('#pendingQuestions').append(questionDiv);
    }

    function archiveQuestion(context) {
        $(context.target.parentNode.parentNode).remove();
    }

    function openQuestion(context) {
        let currentQuestionDiv = $(context.target.parentNode.parentNode);
        currentQuestionDiv.appendTo($('#openQuestions'));
        currentQuestionDiv.removeClass('pendingQuestion');
        currentQuestionDiv.addClass('openQuestion');

        currentQuestionDiv.children('.actions').empty();

        let replyButton = $('<button>');
        replyButton.addClass('reply');
        replyButton.text('Reply');
        replyButton.click(showReplySection);

        let replySectionDiv = $('<div>');
        replySectionDiv.addClass('replySection');
        replySectionDiv.css('display', 'none');
        let replyInput = $('<input class="replyInput" type="text" placeholder="Reply to this question here...">');
        let sendReplyButton = $('<button class="replyButton">Send</button>');
        sendReplyButton.click(sendReply);
        let olElement = $('<ol class="reply" type="1"></ol>');

        replySectionDiv.append(replyInput);
        replySectionDiv.append(sendReplyButton);
        replySectionDiv.append(olElement);
        replySectionDiv.appendTo(currentQuestionDiv);

        currentQuestionDiv.children('.actions').append(replyButton);
    }

    function showReplySection(context) {
        //function changeButtonText() {
        //    $($(context.target)).text(function(i, v){
        //        return v === 'Reply' ? 'Back' : 'Reply'
        //    })
        //}
        //
        //$($(context.target.parentNode.parentNode).children('.replySection')).toggle(changeButtonText);

        if ($($(context.target.parentNode.parentNode).children('.replySection')).css('display') === 'none') {
            $($(context.target.parentNode.parentNode).children('.replySection')).css('display', 'block');
            $(context.target).text('Back');
        }
        else {
            $($(context.target.parentNode.parentNode).children('.replySection')).css('display', 'none');
            $(context.target).text('Reply');
        }
    }

    function sendReply(context) {
        let replySection = $(context.target.parentNode);
        let reply = $(replySection.children('input')[0]).val();
        replySection.children('ol').append($(`<li>${reply}</li>`));
        $(replySection.children('input')[0]).val('');
    }

    document.getElementsByTagName('button')[0].addEventListener('click', sendQuestion);
});