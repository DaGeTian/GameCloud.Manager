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
})($enums || ($enums = {}));