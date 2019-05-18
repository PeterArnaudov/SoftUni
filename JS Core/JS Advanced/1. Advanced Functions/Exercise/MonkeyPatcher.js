function solution(command) {
    let post = this;

    if (command == 'upvote') {
        post['upvotes']++;
    }
    else if (command == 'downvote') {
        post['downvotes']++;
    }
    else if (command == 'score') {
        let rating = '';
        let totalVotes = post['upvotes'] + post['downvotes'];
        let upvotes = post['upvotes'];
        let downvotes = post['downvotes'];
        let tally = upvotes - downvotes;

        if (totalVotes < 10) {
            rating = 'new';
        }
        else if (upvotes / (totalVotes) > 0.66) {
            rating = 'hot';
        }
        else if (tally >= 0 && upvotes > 100 || downvotes > 100) {
            rating = 'controversial';
        }
        else if (tally < 0) {
            rating = 'unpopular';
        }
        else {
            rating = 'new';
        }

        if (totalVotes > 50) {
            let bonus = Math.ceil(Math.max(post['upvotes'], post['downvotes']) * 0.25);
            return [upvotes + bonus, downvotes + bonus, tally, rating];
        }

        return [upvotes, downvotes, tally, rating];
    }
}

let post = {
    id: '3',
    author: 'emil',
    content: 'wazaaaaa',
    upvotes: 100,
    downvotes: 100
};
solution.call(post, 'upvote');
solution.call(post, 'downvote');
let score = solution.call(post, 'score'); // [127, 127, 0, 'controversial']
console.log(score);
for (let i = 0; i < 50; i++) {
    solution.call(post, 'downvote');

}     // (executed 50 times)
score = solution.call(post, 'score');     // [139, 189, -50, 'unpopular']
console.log(score);