var currentActiveIndex = null;

function changeStyle(index) {
    // �����e�@�� active �������˦�
    if (currentActiveIndex !== null) {
        document.querySelector('.machine-navbar div:nth-child(' + (currentActiveIndex + 1) + ')').classList.remove('active');
    }

    // �K�[�s active �������˦�
    document.querySelector('.machine-navbar div:nth-child(' + (index + 1) + ')').classList.add('active');

    // ��s��e active ����������
    currentActiveIndex = index;
}
