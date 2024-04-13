var player;

function onYouTubeIframeAPIReady(videoId) {
    player = new YT.Player('player', {
        height: '100%',
        width: '100%',
        videoId: videoId
    });
}