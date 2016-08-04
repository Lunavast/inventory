﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Interfaces
{
    public interface IBackupService
    {
        bool IsLoggedIn { get; }

        /// <summary>
        ///     Shows a login prompt to the user.
        /// </summary>
        Task Login();

        /// <summary>
        ///     Uploads a copy of the current database.
        /// </summary>
        /// <returns>Returns a TaskCompletionType which indicates if the task was successful or not</returns>
        Task<bool> Upload();

        /// <summary>
        ///     Restores the file with the passed name
        /// </summary
        /// <param name="backupname">Name of the backup to restore</param>
        /// <param name="dbName">filename in which the database shall be restored.</param>
        /// <returns>TaskCompletionType which indicates if the task was successful or not</returns>
        Task Restore(string backupname, string dbName);

        /// <summary>
        ///     Gets a list with all the filenames who are available in the backup folder.
        ///     The name of the backupfolder is defined in the Constants.
        /// </summary>
        /// <returns>A list with all filenames.</returns>
        Task<List<string>> GetFileNames();

        /// <summary>
        ///     Get's the modification date for the existing backup.
        /// </summary>
        /// <returns>Returns the date of the last backup</returns>
        Task<DateTime> GetBackupDate();
    }
}