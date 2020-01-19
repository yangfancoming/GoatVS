

create table sys_fileJob
(
    id INTEGER
        constraint sys_fileJob_pk
        primary key autoincrement,
    jobName string,
    jobCycle string,
    jobType string,
    createTime string,
    fileDirectory string,
    fileMatched string,
    fileSuffix string
);

