(function ($enums) {

    var accountStatusEnum = [{
        name: 'active',
        displayName: '可用',
        value: 0
    }, {
        name: 'disabled',
        displayName: '禁用',
        value: 1
    }];

    $enums.items.push({ name: 'accountStatusEnum', items: accountStatusEnum });

    var accountTypeEnum = [{
        name: 'normalAccount',
        displayName: '普通用户',
        value: 0
    }, {
        name: 'guest',
        displayName: '访客',
        value: 1
    }];

    $enums.items.push({ name: 'accountTypeEnum', items: accountTypeEnum });
})($enums || ($enums = {}));