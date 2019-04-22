(function () {
    'use strict';
    angular.module('clockworkApp').controller('serverdatetimerequestController', serverdatetimerequestController);
    serverdatetimerequestController.$inject = ['$rootScope', '$scope', 'serverdatetimerequestService'];

    function serverdatetimerequestController($rootScope, $scope, serverdatetimerequestService) { 
        $scope.dateTimeRequests = []; 
        
        function getServerDateTimeRequests() {
            serverdatetimerequestService.getServerDateTimeRequests().then(function (items) {
                $scope.dateTimeRequests = items; 
            });
        }

        $scope.addServerDateTimeRequest = function (timeZone) { 
            var payload = { "timeZone": timeZone};
            serverdatetimerequestService.addServerDateTimeRequest(payload).then(function (data) {
                getServerDateTimeRequests();
            });
        };

        getServerDateTimeRequests();
    }
})();