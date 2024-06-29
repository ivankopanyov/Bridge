export { }

declare global {
    export interface Number {
        display(): string;
    }

    export interface Date {
        display(): string;
    }
}

Number.prototype.display = function (this: number)  {
    return this.toString().padStart(2, '0');
}

Date.prototype.display = function (this: Date)  {
    return `${this.getDate().display()}.${(this.getMonth() + 1).display()}.${this.getFullYear()} ${this.getHours().display()}:${this.getMinutes().display()}:${this.getSeconds().display()}`;
}
