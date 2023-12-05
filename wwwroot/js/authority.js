var Delect = document.getElementById("Delect");
var Edit = document.getElementById("Edit");
var Add = document.getElementById("Add");
var Save = document.getElementById("Save");
var Search = document.getElementById("Search");

var result = document.getElementById("result");
var resultemployeeId = document.getElementById("resultemployeeId");
var resultemployeeName = document.getElementById("resultemployeeName");

function search()
{
    event.preventDefault();
    Search.disabled = true;

    var employeeId = document.getElementById("employeeId").value;
    var employeeName = document.getElementById("employeeName").value;

    //LINQ查詢SQL內部資料 確定有值才會查詢成功
    if (employeeId != null && employeeId != "" && employeeName != null && employeeName != null)
    {
        result.textContent = "查詢成功!";
        resultemployeeId.textContent = employeeId;
        resultemployeeName.textContent = employeeName;

        Delect.disabled = false;
        Edit.disabled = false;
    }
    else
    {
        result.textContent = "查無此人!";
        alert("請先新增權限");
        Add.disabled = false;
        
    }
}

function add()
{
    event.preventDefault();
    Search.disabled = true;
    Save.disabled = false;
    Delect.disabled = true;
    Edit.disabled = true;
    Add.disabled = true;
}

function save()
{
    event.preventDefault();
    Save.disabled = false;
    Search.disabled = false;
    Delect.disabled = true;
    Edit.disabled = true;
    Add.disabled = true;

    var saveemployeeId = document.getElementById("employeeId").value;
    var saveemployeeName = document.getElementById("employeeName").value;

    if (saveemployeeId != null && saveemployeeId != "" && saveemployeeName != null && saveemployeeName != null) {
        result.textContent = "存檔成功!";
        resultemployeeId.textContent = saveemployeeId;
        resultemployeeName.textContent = saveemployeeName;
        Save.disabled = true;
    }
    else
    {
        alert("請確定工號與姓名都有填寫!")
    }
}


function edit()
{
    event.preventDefault();
    Save.disabled = false;
    Search.disabled = false;
    Delect.disabled = true;
    Edit.disabled = true;
    Add.disabled = true;
}

function delect()
{
    event.preventDefault();
    Save.disabled = true;
    Search.disabled = true;
    Delect.disabled = true;
    Edit.disabled = true;
    Add.disabled = true;

    var flag = confirm("是否要刪除資料?")

    var deleteemployeeId = document.getElementById("employeeId").value;
    var deleteemployeeName = document.getElementById("employeeName").value;

    if (flag && deleteemployeeId != null && deleteemployeeId != "" && deleteemployeeName != null && deleteemployeeName != "")
    {
        deleteemployeeId = "";
        deleteemployeeName = "";

        document.getElementById("employeeId").value = "";
        document.getElementById("employeeName").value = "";

        
    }
    else
    {
        alert("刪除失敗!")
        result.textContent = "刪除失敗!";
    }

    result.textContent = "刪除成功!";
    resultemployeeId.textContent = deleteemployeeId;
    resultemployeeName.textContent = deleteemployeeName;

    Search.disabled = false;
}