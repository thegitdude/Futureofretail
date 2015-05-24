var statistics = {
    loadBarcodeChart: function () {
        this.getStatistics('barcode');
    },
    loadBeaconUsageChart: function () {
        this.getStatistics('beacon');
    },
    loadProductChart: function () {
       
        this.getStatistics('test');
    },
    construct:function(data)
    {
        var ctx = document.getElementById("myChart").getContext("2d");
        barData.labels = data.labels;
        barData.datasets.data = data.datasets.data;
        console.log(data);
        var myNewChart = new Chart(ctx).Bar(data);
    },
    getStatistics: function (tag)
    {
        var that = this;
            $.ajax({
                url: "controllers/statisticsController.aspx/GetStatistics?tag='"+tag+"'",
                contentType: "application/json; charset=utf-8",
                type: "GET",
                success: function (data) {
               
                    that.construct(data.d);
                      
                },
                error: function (data) {
                    alert("error occured");
                }
            });
    }
};

var barData = {
    labels: ['Italy', 'UK', 'USA', 'Germany', 'France', 'Japan'],
    datasets: [
        {
            label: '2010 customers #',
            fillColor: '#382765',
            data: [2500, 1902, 1041, 610, 1245, 952]
        },
        
    ]
};