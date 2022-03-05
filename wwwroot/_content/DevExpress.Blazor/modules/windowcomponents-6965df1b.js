import{a as t}from"./_tslib-1f2a369a.js";import{D as o,a as s}from"./popup-9c592b3d.js";import{B as e,a as r}from"./popuproot-e58b0e44.js";import{i}from"./query-44b9267f.js";import{a as l,y as p,e as a,n as d,r as n}from"./property-d63bb995.js";import{D as b}from"./popupbasedialog-d87b07fb.js";import{dxBranchTagName as h}from"./branch-a902b7e1.js";import"./rect-2684652a.js";import"./point-9c6ab88a.js";import"./rafaction-bba7928b.js";import"./transformhelper-3935ca6a.js";import"./layouthelper-c2462bd3.js";import"./positiontracker-9570b24e.js";import"./positiontrackerobserver-5fd93b2c.js";import"./pointer-event-helper-af17dc0d.js";import"./dx-ui-element-834c6d10.js";import"./data-qa-utils-8be7c726.js";import"./capturemanager-f28d279d.js";import"./eventhelper-dec6cde0.js";let m=class extends o{renderTemplate(){return p`
            <dxbl-branch
                id="${this.branchId}"
                parent-id="${this.parentBranchId}"
                type="${e.Window}">
                <dxbl-window-root
                    id="root"
                    style="${this.rootCssStyle}"
                    resizing="${this.resizing}"
                    drop-opposite="${this.actualDropOpposite}"
                    drop-direction="${this.actualDropDirection}">
                    ${this.renderSlot()}
                </dxbl-window-root>
            </dxbl-branch>
        `}get child(){return this.root}renderSlot(){return p`
            <slot></slot>
            <slot name="top" slot="top"></slot>
            <slot name="right" slot="right"></slot>
            <slot name="bottom" slot="bottom"></slot>
            <slot name="left" slot="left"></slot>
            <slot name="top-left" slot="top-left"></slot>
            <slot name="top-right" slot="top-right"></slot>
            <slot name="bottom-left" slot="bottom-left"></slot>
            <slot name="bottom-right" slot="bottom-right"></slot>
        `}};t([i("#root",!0)],m.prototype,"root",void 0),m=t([l("dxbl-window")],m);let c=class extends b{};c=t([l("dxbl-dropdown-dialog")],c);let u=class extends d{constructor(){super(...arguments),this.topLeftClass=null,this.topRightClass=null,this.bottomLeftClass=null,this.bottomRightClass=null,this.dropOpposite=!1,this.dropDirection=s.Near,this.resizing=!1}static get styles(){return n`
            :host {
                display: flex;
                box-sizing: border-box;
            }
            .hidden {
                display: none;
            }
            ::slotted {
                min-width: 8px;
                min-height: 8px;
            }
            ::slotted([slot="top-left"]) {
                position: absolute;
                z-index: 1;
                top: 0px;
                left: 0px;
                transform: rotate(-90deg);
                cursor: nw-resize;
            }
            ::slotted([slot="top-right"]) {
                position: absolute;
                z-index: 1;
                top: 0px;
                right: 0px;
                transform: rotate(-180deg);
                cursor: ne-resize;
            }
            ::slotted([slot="bottom-left"]) {
                position: absolute;
                z-index: 1;
                bottom: 0px;
                left: 0px;
                transform: rotate(-270deg);
                cursor: sw-resize;
            }
            ::slotted([slot="bottom-right"]) {
                position: absolute;
                z-index: 1;
                bottom: 0px;
                right: 0px;
                cursor: se-resize;
                transform: rotate(0deg);
            }
        }`}connectedCallback(){super.connectedCallback(),this.calculateStyles(this.resizing,this.dropOpposite,this.dropDirection)}willUpdate(t){(t.has("dropOpposite")||t.has("dropDirection")||t.has("resizing"))&&this.calculateStyles(this.resizing,this.dropOpposite,this.dropDirection)}calculateStyles(t,o,e){this.topLeftClass=t&&o&&e===s.Far?null:"hidden",this.topRightClass=t&&o&&e===s.Near?null:"hidden",this.bottomLeftClass=t&&!o&&e===s.Far?null:"hidden",this.bottomRightClass=t&&!o&&e===s.Near?null:"hidden"}render(){return p`
            <slot></slot>
            <dxbl-thumb>
                <slot name="top"></slot>
            </dxbl-thumb>
            <dxbl-thumb>
                <slot name="right"></slot>
            </dxbl-thumb>
            <dxbl-thumb>
                <slot name="bottom"></slot>
            </dxbl-thumb>
            <dxbl-thumb>
                <slot name="left"></slot>
            </dxbl-thumb>
            <dxbl-thumb class="${this.topLeftClass}">
                <slot name="top-left"></slot>
            </dxbl-thumb>
            <dxbl-thumb class="${this.topRightClass}">
                <slot name="top-right"></slot>
            </dxbl-thumb>
            <dxbl-thumb class="${this.bottomLeftClass}">
                <slot name="bottom-left"></slot>
            </dxbl-thumb>
            <dxbl-thumb class="${this.bottomRightClass}">
                <slot name="bottom-right"></slot>
            </dxbl-thumb>`}};t([a({type:String,reflect:!1})],u.prototype,"topLeftClass",void 0),t([a({type:String,reflect:!1})],u.prototype,"topRightClass",void 0),t([a({type:String,reflect:!1})],u.prototype,"bottomLeftClass",void 0),t([a({type:String,reflect:!1})],u.prototype,"bottomRightClass",void 0),t([a({type:Object,attribute:"drop-opposite"})],u.prototype,"dropOpposite",void 0),t([a({type:String,attribute:"drop-direction"})],u.prototype,"dropDirection",void 0),t([a({type:Object,attribute:"resizing"})],u.prototype,"resizing",void 0),u=t([l("dxbl-window-root")],u);function f(t){return t}const g={getReference:f,registeredComponents:["dxbl-window","dxbl-dropdown-dialog",r,"dxbl-window-root",h]};export{g as default,f as getReference};
