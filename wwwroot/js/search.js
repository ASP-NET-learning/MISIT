var currentActiveIndex = null;

function changeStyle(index) {
    // 移除前一個 active 元素的樣式
    if (currentActiveIndex !== null) {
        document.querySelector('.machine-navbar div:nth-child(' + (currentActiveIndex + 1) + ')').classList.remove('active');
    }

    // 添加新 active 元素的樣式
    document.querySelector('.machine-navbar div:nth-child(' + (index + 1) + ')').classList.add('active');

    // 更新當前 active 元素的索引
    currentActiveIndex = index;
}
