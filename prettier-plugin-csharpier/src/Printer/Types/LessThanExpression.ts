import { PrintMethod } from "../PrintMethod";
import { LeftRightExpression, printLeftRightExpression, SyntaxTreeNode } from "../SyntaxTreeNode";
import { concat, group, hardline, indent, join, softline, line, doubleHardline } from "../Builders";

export interface LessThanExpressionNode extends SyntaxTreeNode<"LessThanExpression">, LeftRightExpression {}

export const print: PrintMethod<LessThanExpressionNode> = (path, options, print) => {
    return printLeftRightExpression(path, print);
};
