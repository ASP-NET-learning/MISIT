
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
        greeting = "���W�n!";
        iconClass = "fas fa-sun";
    }
    else if (hours >= 12 && hours < 18)
    {
        greeting = "�U�Ȧn!";
        iconClass = "fas fa-cloud-sun";
    } else
    {
        greeting = "�ߤW�n!";
        iconClass = "fas fa-moon";
    }
console.log("2" + greeting);
console.log(hours);

document.getElementById("greeting").textContent = greeting;
document.getElementById("timeDisplay").innerText = "�ثe�ɶ���: " + timeString;
document.getElementById("timeIcon").className = iconClass;

}

// ��l�ƭ����ɧ�s�@���ɶ�
updateTime();

// �C���s�@���ɶ�
setInterval(updateTime, 1000);


