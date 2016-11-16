(function ($enums) {

    var canShowRanking = [{
        name: 'true',
        displayName: '显示',
        value: true
    }, {
        name: 'false',
        displayName: '不显示',
        value: false
    }];

    $enums.items.push({ name: 'canShowRanking', items: canShowRanking });

    var canShowSendChips = [{
        name: 'true',
        displayName: '可赠送',
        value: true
    }, {
        name: 'false',
        displayName: '不可赠送',
        value: false
    }];

    $enums.items.push({ name: 'canShowSendChips', items: canShowSendChips });

    var sysNoticeType = [{
        name: 'Sys',
        displayName: '系统',
        value: 1
    }, {
        name: 'Player',
        displayName: '玩家',
        value: 2
    }];

    $enums.items.push({ name: 'sysNoticeType', items: sysNoticeType });

    var sysNoticeLevel = [{
        name: 'Normal',
        displayName: '普通',
        value: 1
    }, {
        name: 'Important',
        displayName: '重要',
        value: 2
    }];

    $enums.items.push({ name: 'sysNoticeLevel', items: sysNoticeLevel });

    var produceChipType = [{
        name: 'BuyInGame',
        displayName: '游戏内购买',
        value: 1
    }, {
        name: 'BuyFromGM',
        displayName: '通过后台购买',
        value: 2
    }, {
        name: 'DailySendBySys',
        displayName: '每日赠送',
        value: 3
    }, {
        name: 'LostAllThenSendBySys',
        displayName: '输光后赠送',
        value: 4
    }, {
        name: 'BotSysSeedMoney',
        displayName: '机器人系统初始资金',
        value: 5
    }];

    $enums.items.push({ name: 'produceChipType', items: produceChipType });
})($enums || ($enums = {}));