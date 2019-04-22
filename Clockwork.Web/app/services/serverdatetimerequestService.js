 (function () {
    'use strict';
     angular.module('clockworkApp').factory('serverdatetimerequestService', ['$http', '$q', serverdatetimerequestService]);

     function serverdatetimerequestService($http, $q) {
         return {
             getServerDateTimeRequests: getServerDateTimeRequests,
             addServerDateTimeRequest: addServerDateTimeRequest
         };

         function getServerDateTimeRequests() {
             return $http.get('http://localhost:56627/api/server-time-requests').then(function (success) {
                 return success.data;
             }, function (error) {
                 return error;
             });
         }

         function addServerDateTimeRequest(payload) {
             return $http.post('http://localhost:56627/api/server-time-requests', payload).then(function (success) {
                 return success.data;
             }, function (error) {
                 return error;
             });
         }
     }
})();
