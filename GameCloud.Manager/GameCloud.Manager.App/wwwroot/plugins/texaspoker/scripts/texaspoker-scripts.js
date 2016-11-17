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
        name: 'SellItem',
        displayName: '卖属性',
        value: 5
    }, {
        name: 'BotSysSeedMoney',
        displayName: '机器人系统初始资金',
        value: 6
    }];

    $enums.items.push({ name: 'produceChipType', items: produceChipType });

    var produceGoldType = [{
        name: 'BuyInGame',
        displayName: '游戏内购买',
        value: 1
    }, {
        name: 'BuyFromGM',
        displayName: '通过后台购买',
        value: 2
    }, {
        name: 'SellItem',
        displayName: '卖属性',
        value: 3
    }];

    $enums.items.push({ name: 'produceGoldType', items: produceGoldType });

    var recoverChipType = [{
        name: 'BuyGiftTmp',
        displayName: '购买临时礼物',
        value: 1
    }, {
        name: 'BuyItem',
        displayName: '购买属性',
        value: 2
    }, {
        name: 'SeatFee',
        displayName: '台费',
        value: 3
    }, {
        name: 'SysPumping',
        displayName: '抽水',
        value: 4
    }, {
        name: 'RecoverByGM',
        displayName: '通过后台回收',
        value: 5
    }];

    $enums.items.push({ name: 'recoverChipType', items: recoverChipType });

    var recoverGoldType = [{
        name: 'BuyGiftTmp',
        displayName: '购买临时礼物',
        value: 1
    }, {
        name: 'BuyItem',
        displayName: '购买属性',
        value: 2
    }, {
        name: 'RecoverByGM',
        displayName: '通过后台回收',
        value: 3
    }];

    $enums.items.push({ name: 'recoverGoldType', items: recoverGoldType });

    var isClassic = [{
        name: 'false',
        displayName: '必下',
        value: false
    }, {
        name: 'true',
        displayName: '经典',
        value: true
    }];

    $enums.items.push({ name: 'isClassic', items: isClassic });
})($enums || ($enums = {}));