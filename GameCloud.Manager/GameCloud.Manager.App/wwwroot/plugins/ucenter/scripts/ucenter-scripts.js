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

$pluginApp.controller('ucenterUserStatisticsController', ['$scope', '$http', '$templateCache', '$controller', 'pluginService', function ($scope, $http, $templateCache, $controller, pluginService) {
    $controller('chartController', { $scope: $scope });
    var lastMonth = Date.today();
    lastMonth.setMonth(lastMonth.getMonth() - 1);
    $scope.params.startDate = lastMonth;
    $scope.params.endDate = Date.today();
    $scope._sync();
}])
.controller('ucenterNewUsersController', ['$scope', '$http', '$templateCache', '$controller', 'pluginService', function ($scope, $http, $templateCache, $controller, pluginService) {
    $controller('chartController', { $scope: $scope });

    $scope.params.startDate = Date.yesterday();
    $scope.params.endDate = Date.today();
    $scope.charts = [[{
        title: '小时新增帐户',
        description: '统计所选时期内，每日玩家激活游戏后，进行了自动或者手动注册有ID信息或者账户信息的玩家账户数量。',
        key: 'hourlyNewUsers'
    }, {
        title: '小时新增设备',
        description: '统计所选时期内，每日玩家激活游戏后，进行了自动或者手动注册有ID信息或者账户信息的玩家设备数量，每台设备只计算一次。',
        key: 'hourlyNewUsers'
    }],
    [{
        title: '小时设备激活',
        description: '"统计所选时期内，每日新增的玩家安装游戏客户端，并运行游戏的可连接网络设备的数量，每台设备只计算一次。',
        key: 'hourlyNewUsers'
    }, {
        title: '小时玩家转化率',
        description: '统计所选时期内，每日玩家激活游戏后，进行了自动或者手动注册有ID信息或者账户信息的玩家设备数量，单设备中多个帐号只计算一次成功转化。',
        key: 'hourlyNewUsers'
    }],
    [{
        title: '小时首次游戏时长',
        description: '统计所选时期内，新增玩家首次进行游戏的游戏时间区间分布。',
        key: 'hourlyNewUsers'
    }, {
        title: '小时新增玩家地区/国家',
        description: '统计所选时期内，新增玩家注册信息中地区和国家分布情况。',
        key: 'hourlyNewUsers'
    }],
    [{
        title: '小时新增玩家性别',
        description: '统计所选时期内，新增玩家注册信息中性别分布情况。',
        key: 'hourlyNewUsers'
    }, {
        title: '小时新增玩家年龄',
        description: '统计所选时期内，新增玩家注册信息中年龄分布情况。',
        key: 'hourlyNewUsers'
    }]];

    $scope.fetch = function () {
        $scope._sync(function (isSuccess, response) {
            if (isSuccess) {
                $scope.charts.forEach(function (row) {
                    row.forEach(function (chart) {
                        chart.data = response.data[chart.key];
                    });
                })
            }
        });
    };

    $scope.fetch();
}]);