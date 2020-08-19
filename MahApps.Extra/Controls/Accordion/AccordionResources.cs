using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahApps.Extra.Controls
{
    public class AccordionResources
    {
        public const string Accordion_InvalidManipulationOfSelectionCollections = "The modification made to the collection lead to an invalid Selection state. Please check the SelectionMode to allow zero or multiple items.";
        public const string Accordion_OnActionFinish_InvalidFinish = "Should not signal a finish when item is not expected to perform an action.";
        public const string Accordion_OnExpandDirectionPropertyChanged_InvalidValue = "Invalid ExpandDirection value '{0}'.";
        public const string Accordion_OnSelectedIndicesChanged_InvalidWrite = "Cannot set read-only property SelectedIndices.";
        public const string Accordion_OnSelectedItemsChanged_InvalidWrite = "Cannot set read-only property SelectedItems.";
        public const string Accordion_OnSelectionModePropertyChanged_InvalidValue = "Invalid SelectionMode value '{0}'.";
        public const string Accordion_OnSelectionSequencepropertyChanged_InvalidValue = "Invalid SelectionSequence value '{0}'.";
        public const string Accordion_UnsupportedCollectionAction = "Unsupported collection action '{0}'.";
        public const string AccordionItem_InvalidWriteToContentTargetSize = "ContentTargetSize is a read-only value and is set through Accordion.";
        public const string AccordionItem_InvalidWriteToExpandDirection = "ExpandDirection is a read-only value and is set through Accordion.";
        public const string AccordionItem_OnIsSelectedPropertyChanged_InvalidChange = "Cannot modify the IsSelected property while item is locked.";
        public const string AccordionItem_StartAction_InvalidAction = "Invalid Action '{0}'.";
        public const string AccordionItem_StartAction_InvalidCall = "Cannot start an action when there is no action scheduled.";

        public const string Automation_OperationCannotBePerformed = "Cannot perform operation.";
        public const string Expander_OnExpandDirectionPropertyChanged_InvalidValue = "Invalid ExpandDirection value '{0}'.";
        public const string TransitioningContentControl_TransitionNotFound = "Transition '{0}' was not defined.";
        public const string TransitiotioningContentControl_IsTransitioningReadOnly = "IsTransitioning property is read-only.";
    }
}
