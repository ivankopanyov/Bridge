export const toDisplayDateTime = (date: Date) =>
    `${toDisplayNumber(date.getDate())}.${toDisplayNumber(date.getMonth())}.${date.getFullYear()} ${toDisplayNumber(date.getHours())}:${toDisplayNumber(date.getMinutes())}:${toDisplayNumber(date.getSeconds())}`;

const toDisplayNumber = (value: number) => value.toString().padStart(2, '0')