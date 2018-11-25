namespace BLogger
{
    /// <summary>Состояния БЛоггера. </summary>
    public enum BloggerState
    {
        /// <summary>Успешно. </summary>
        Success = 0,

        /// <summary>Настройки не найдены. </summary>
        SettingsNotFound = 1,

        /// <summary>Неизвестная ошибка. </summary>
        UnknownError = 99,
    }
}
