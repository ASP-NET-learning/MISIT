
function updateTime()
{
    var time = new Date();
    var hours = time.getHours();
    var timeString = time.toLocaleString();
    var greeting = "";
    var iconClass = "";

console.log("1"+greeting);
console.log(hours);
    if (hours >= 6 && hours < 12)
    {
        greeting = "早上好!";
        iconClass = "fas fa-sun";
    }
    else if (hours >= 12 && hours < 18)
    {
        greeting = "下午好!";
        iconClass = "fas fa-cloud-sun";
    } else
    {
        greeting = "晚上好!";
        iconClass = "fas fa-moon";
    }
console.log("2" + greeting);
console.log(hours);

document.getElementById("greeting").textContent = greeting;
document.getElementById("timeDisplay").innerText = "目前時間為: " + timeString;
document.getElementById("timeIcon").className = iconClass;

}

// 初始化頁面時更新一次時間
updateTime();

// 每秒更新一次時間
setInterval(updateTime, 1000);


