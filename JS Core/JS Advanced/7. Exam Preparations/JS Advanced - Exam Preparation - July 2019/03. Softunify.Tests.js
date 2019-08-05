const assert = require('chai').assert;
const Softunify = require('./03. Softunify');
let softunify = new Softunify();

describe("Softunify Tests", function() {
    beforeEach(function () {
        softunify = new Softunify();
    });

    describe("Constructor tests", function() {
        it("Initialize empty allSongs", function() {
            assert.equal(Object.entries(softunify.allSongs).length, 0);
        });
    });

    describe("downloadSong method tests", function () {
        it("should set a new artist if it doesn't exist already", function () {
            let artistName = 'Name';
            softunify.downloadSong(artistName);

            assert.isTrue(softunify.allSongs.hasOwnProperty(artistName));
        });

        it("should set a new artist with properties", function () {
            let artistName = 'Name';

            softunify.downloadSong(artistName);

            assert.equal(softunify.allSongs[artistName]["rate"], 0);
            assert.equal(softunify.allSongs[artistName]["votes"], 0);
            assert.equal(softunify.allSongs[artistName]["songs"].length, 1);
        });

        it("should add the song", function () {
            let artistName = 'Name';
            let songName = 'Name';
            let songLyrics = 'Lyrics';

            softunify.downloadSong(artistName, songName, songLyrics);

            assert.equal(softunify.allSongs[artistName]["songs"][0], `${songName} - ${songLyrics}`);
        });

        it("should add second song of an artist", function () {
            let artistName = 'Name';
            let songName = 'Name';
            let songLyrics = 'Lyrics';

            softunify.downloadSong(artistName, songName, songLyrics);
            softunify.downloadSong(artistName, songName, songLyrics);

            assert.equal(softunify.allSongs[artistName]["songs"][1], `${songName} - ${songLyrics}`);
        });
    })
});
