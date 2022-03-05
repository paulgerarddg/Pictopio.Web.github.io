import{a as n}from"./_tslib-1f2a369a.js";import{i as e}from"./dx-ui-element-834c6d10.js";import{P as t}from"./pointer-event-helper-af17dc0d.js";import{DxUIHandlersBridgeTagName as o}from"./dx-ui-handlers-bridge-4076ae57.js";import{D as i}from"./dx-dropdown-owner-6316b2ef.js";import{e as s}from"./property-d63bb995.js";class r extends i{constructor(){super(),this.boundOnKeyDownHandler=this.onKeyDown.bind(this),this.boundOnFocusOutHandler=this.onFocusOut.bind(this),this.boundOnClickHandler=this.onClick.bind(this),this.boundOnDropDownButtonClickHandler=this.onDropDownButtonClick.bind(this),this.isDropDownOpen=!1,this.dropDownButtonElement=null,this._inputElement=null,this._uiHandlersBridge=null}get inputElement(){return this._inputElement}get uiHandlersBridge(){return this._uiHandlersBridge}connectedCallback(){super.connectedCallback(),this.addEventListener("keydown",this.boundOnKeyDownHandler),this.addEventListener("focusout",this.boundOnFocusOutHandler),this.addEventListener("click",this.boundOnClickHandler)}disconnectedCallback(){var n;this._inputElement=null,null===(n=this.dropDownButtonElement)||void 0===n||n.removeEventListener("click",this.boundOnDropDownButtonClickHandler),this.dropDownButtonElement=null,this._uiHandlersBridge=null,this.removeEventListener("keydown",this.boundOnKeyDownHandler),this.removeEventListener("focusout",this.boundOnFocusOutHandler),this.removeEventListener("click",this.boundOnClickHandler),super.disconnectedCallback()}getInputElement(){return this.querySelector("input")}onSlotChanged(n){var t;super.onSlotChanged(n),this.dropDownButtonElement=this.querySelector(".dxbs-editor-dropdown-button"),null===(t=this.dropDownButtonElement)||void 0===t||t.addEventListener("click",this.boundOnDropDownButtonClickHandler),this._inputElement=this.getInputElement(),e(this.inputElement,(()=>["logicalParent"]))&&this.addLogicalChild(this.inputElement),this._uiHandlersBridge=this.querySelector(o)}onKeyDown(n){this.isDropDownOpen||this.invokeKeyDownServerCommand(n)}onDropDownShown(n){var e;super.onDropDownShown(n),null===(e=this.inputElement)||void 0===e||e.focus()}onFocusOut(n){var e;const t=n.relatedTarget;t&&(this.contains(t)||(null===(e=this.dropDownElement)||void 0===e?void 0:e.contains(t)))||this.processLostFocus()}onClick(n){var e;null===(e=this.inputElement)||void 0===e||e.focus()}onDropDownButtonClick(n){this.toggleDropDownVisibility()}canHandlePointerDown(n){return t.containsInComposedPath(n,this.dropDownButtonElement)||t.containsInComposedPath(n,this.inputElement)}invokeKeyDownServerCommand(n){return r.isToggleDropDownVisibilityKeyCommand(n)?(this.toggleDropDownVisibility(),!0):super.invokeKeyDownServerCommand(n)}processLostFocus(){}ensureDropDownElement(){super.ensureDropDownElement(),this.dropDownElement&&this.dropDownElement.addEventListener("focusout",this.boundOnFocusOutHandler)}disposeDropDownElement(){super.disposeDropDownElement(),this.dropDownElement&&this.dropDownElement.removeEventListener("focusout",this.boundOnFocusOutHandler)}toggleDropDownVisibility(){var n;null===(n=this.uiHandlersBridge)||void 0===n||n.send(this.isDropDownOpen?"closeDropDown":"openDropDown",{})}static isToggleDropDownVisibilityKeyCommand(n){return(n.altKey||n.metaKey)&&("ArrowUp"===n.key||"ArrowDown"===n.key)}}n([s({type:Boolean,attribute:"is-dropdown-open"})],r.prototype,"isDropDownOpen",void 0);export{r as D};
